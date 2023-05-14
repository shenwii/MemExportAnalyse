using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace MemExportAnalyse
{
    public partial class Form1 : Form
    {
        private enum SYSTEM_ENUM
        {
            BIN,
            HEX,
            DEC,
        };
        private SYSTEM_ENUM system;
        private const int HEADER_LEN = 24 - 4;
        private const int DATA_LEN = 4096 * 2;
        //��������
        private List<int> datas = new List<int>();
        //���ݳ���
        int dataLen = 0;
        int byteLen = 0;
        //��һ������
        Point? prevPosition = null;
        //����Ϣ
        DataTable pointTable = new DataTable();
        int pointIdx = 1;

        public Form1()
        {
            InitializeComponent();
            pointTable.Columns.Add(new DataColumn("point", typeof(String)));
            pointTable.Columns.Add(new DataColumn("xValue", typeof(Int32)));
            pointTable.Columns.Add(new DataColumn("yValue", typeof(Double)));
            pointTable.Columns.Add(new DataColumn("dataPoint", typeof(DataPoint)));
            pointGrid.AutoGenerateColumns = true;
            pointGrid.DataSource = pointTable;
            pointGrid.Columns["point"].HeaderText = "��";
            pointGrid.Columns["xValue"].HeaderText = "X";
            pointGrid.Columns["yValue"].HeaderText = "Y";
            pointGrid.Columns["dataPoint"].Visible = false;
            var buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "delete";
            buttonColumn.Text = "ɾ��";
            buttonColumn.HeaderText = "ɾ��";
            buttonColumn.UseColumnTextForButtonValue = true;
            pointGrid.Columns.Add(buttonColumn);
        }

        private void systemSet(object? sender, EventArgs? e)
        {
            if (radioBin.Checked)
            {
                system = SYSTEM_ENUM.BIN;
            }
            else if (radioHex.Checked)
            {
                system = SYSTEM_ENUM.HEX;

            }
            else
            {
                system = SYSTEM_ENUM.DEC;
            }
        }

        private void mainFormLoad(object sender, EventArgs e)
        {
            systemSet(null, null);
            chart1.Series.Clear();
        }

        private void analyseClick(object? sender, EventArgs? e)
        {
            //�и�������ʽ
            Regex splitReg = new Regex("\\s+");
            //ʮ������ƥ��������ʽ��������ִ�Сдע�⣩
            Regex hexReg = new Regex("^[0-9abcdef]+$");
            //�������ݣ����4����
            Queue<int> numQueue = new Queue<int>();
            if (progressBar1.Visible)
            {
                MessageBox.Show("��ǰ���ڴ�����......");
                return;
            }
            if (String.IsNullOrEmpty(fileNameTextBox.Text))
                return;

            //���ݳ�ʼ��
            datas.Clear();
            pointTable.Clear();
            pointIdx = 1;
            dataLen = 0;
            byteLen = 0;

            //ͷ֡��һЩ����
            bool isVaild = false;
            int headerLen = 0;
            int vaildDataLen = 0;

            Stream? stream = null;
            StreamReader? streamReader = null;
            try
            {
                stream = openFileDialog.OpenFile();
            }
            catch (Exception err)
            {
                MessageBox.Show("��ȡ�ļ�����" + err.Message);
                return;
            }
            try
            {
                streamReader = new StreamReader(stream);
            }
            catch (Exception err)
            {
                try
                {
                    stream.Close();
                }
                catch (IOException) { }
                MessageBox.Show("��ȡ�ļ�����" + err.Message);
                return;
            }
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            Task.Run(() =>
            {
                try
                {
                    string? line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            progressBar1.Value = (int)(stream.Position * 1000 / stream.Length);
                        }));
                        foreach (string data in splitReg.Split(line))
                        {
                            if (!hexReg.IsMatch(data))
                                continue;
                            int len = data.Length;
                            if (dataLen != 0)
                            {
                                //��֮ǰ�����ݳ��Ȳ�һ��
                                if (dataLen != len)
                                    continue;
                            }
                            else
                            {
                                //�ǺϷ�����
                                if (len != 2 && len != 4 && len != 8)
                                    continue;
                                dataLen = len;
                                byteLen = len >> 1;
                            }
                            //ת��������
                            int num = 0;
                            //ת�ɵ����ֽڷŽ�ȥ
                            if (byteLen == 1)
                            {
                                num = Convert.ToByte(data, 8 * byteLen);
                                numQueue.Enqueue(num & 0xff);
                            }
                            else if (byteLen == 2)
                            {
                                num = Convert.ToInt16(data, 8 * byteLen);
                                numQueue.Enqueue((num >> 8) & 0xff);
                                numQueue.Enqueue(num & 0xff);
                            }
                            else if (byteLen == 4)
                            {
                                num = Convert.ToInt32(data, 8 * byteLen);
                                numQueue.Enqueue((num >> 24) & 0xff);
                                numQueue.Enqueue((num >> 16) & 0xff);
                                numQueue.Enqueue((num >> 8) & 0xff);
                                numQueue.Enqueue(num & 0xff);
                            }
                            //ɾ����������
                            int dl = numQueue.Count - 4;
                            while (dl-- > 0)
                                numQueue.Dequeue();
                            if (hasHeader.Checked)
                            {
                                //�������Ч����
                                if (isVaild)
                                {
                                    //���ж��Ƿ���ͷ��
                                    if (headerLen > 0)
                                    {
                                        headerLen -= byteLen;
                                    }
                                    else
                                    {
                                        datas.Add(num);
                                        vaildDataLen -= byteLen;
                                        //���ݶ���
                                        if (vaildDataLen <= 0)
                                        {
                                            isVaild = false;
                                        }
                                    }
                                }
                                else
                                {
                                    if (numQueue.Count == 4 && numQueue.All(num => num == 0xfd))
                                    {
                                        isVaild = true;
                                        headerLen = HEADER_LEN;
                                        vaildDataLen = DATA_LEN;
                                    }
                                }
                            }
                            else
                            {
                                datas.Add(num);
                            }
                        }
                    }
                    this.BeginInvoke(new Action(() =>
                    {
                        chart1.Series.Clear();
                        chart1.ChartAreas.Clear();
                        chart1.ChartAreas.Add(new ChartArea(""));
                        string legend1 = "����";
                        chart1.Series.Add(legend1);
                        chart1.Series[legend1].ChartType = SeriesChartType.Line;
                        for (int i = 0; i < datas.Count; i++)
                        {
                            int num = datas[i];
                            chart1.Series[legend1].Points.Add(new DataPoint(i + 1, num));
                        }
                        //��ȡ����
                        int max = int.MinValue;
                        List<DataPoint> maxPoints = new List<DataPoint>();
                        foreach (DataPoint point in chart1.Series[legend1].Points)
                        {
                            if (max == (int)point.YValues[0])
                            {
                                maxPoints.Add(point);
                            }
                            else if ((int)point.YValues[0] > max)
                            {
                                max = (int)point.YValues[0];
                                maxPoints.Clear();
                                maxPoints.Add(point);
                            }
                        }
                        maxPoints.ForEach(point =>
                        {
                            drawPoint(point);
                        });
                        chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                        chart1.ChartAreas[0].CursorX.AutoScroll = true;
                        chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                    }));
                }
                catch (Exception err)
                {
                    MessageBox.Show("��ȡ�ļ�����" + err.Message);
                }
                finally
                {
                    progressBar1.BeginInvoke(new Action(() =>
                    {
                        progressBar1.Visible = false;
                    }));
                    try
                    {
                        streamReader.Close();
                    }
                    catch (IOException) { }
                    try
                    {
                        stream.Close();
                    }
                    catch (IOException) { }
                }
            });
        }

        private void undrawPoint(DataPoint? point)
        {
            if (point == null)
                return;
            point.Label = "";
            point.MarkerStyle = MarkerStyle.None;
        }
        private void drawPoint(DataPoint point)
        {
            point.Label = $"M{pointIdx++}";
            point.MarkerStyle = MarkerStyle.Circle;
            point.MarkerColor = Color.Red;
            point.MarkerSize = 8;
            DataRow row = pointTable.NewRow();
            row["point"] = point.Label;
            row["xValue"] = point.XValue;
            row["yValue"] = point.YValues[0];
            row["dataPoint"] = point;
            pointTable.Rows.Add(row);
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            DialogResult dialogResult = sfd.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;
            Stream? stream = null;
            StreamWriter? streamWriter = null;
            try
            {
                stream = sfd.OpenFile();
                streamWriter = new StreamWriter(stream);
                switch (system)
                {
                    case SYSTEM_ENUM.BIN:
                        datas.ForEach(num =>
                        {
                            if (byteLen == 1)
                            {
                                streamWriter.WriteLine(Convert.ToString((byte)num, 8 * byteLen).PadLeft(8 * byteLen, '0'));
                            }
                            else if (byteLen == 2)
                            {
                                streamWriter.WriteLine(Convert.ToString((Int16)num, 8 * byteLen).PadLeft(8 * byteLen, '0'));
                            }
                            else if (byteLen == 4)
                            {
                                streamWriter.WriteLine(Convert.ToString(num, 8 * byteLen).PadLeft(8 * byteLen, '0'));
                            }
                        });
                        break;
                    case SYSTEM_ENUM.DEC:
                        datas.ForEach(num =>
                        {
                            streamWriter.WriteLine(num.ToString());
                        });
                        break;
                    case SYSTEM_ENUM.HEX:
                        datas.ForEach(num =>
                        {
                            if (byteLen == 1)
                            {
                                streamWriter.WriteLine(((byte)num).ToString("X" + (byteLen * 2)));
                            }
                            else if (byteLen == 2)
                            {
                                streamWriter.WriteLine(((Int16)num).ToString("X" + (byteLen * 2)));
                            }
                            else if (byteLen == 4)
                            {
                                streamWriter.WriteLine(num.ToString("X" + (byteLen * 2)));
                            }
                        });
                        break;
                }
            }
            catch (IOException err)
            {
                MessageBox.Show("д���ļ�����" + err.Message);
            }
            finally
            {
                try
                {
                    if (streamWriter != null)
                        streamWriter.Close();
                }
                catch (IOException) { }
                try
                {
                    if (stream != null)
                        stream.Close();
                }
                catch (IOException) { }
            }

        }

        private void fileSelectClick(object sender, EventArgs e)
        {
            //���ļ�
            DialogResult dialogResult = openFileDialog.ShowDialog();
        }

        private void fileIsSelected(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fileNameTextBox.Text = openFileDialog.FileName;
            analyseClick(null, null);
        }

        private void fileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void fileDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;
            object data = e.Data.GetData(DataFormats.FileDrop);
            if (data is Array)
            {
                string? path = (data as Array)?.GetValue(0)?.ToString();
                if (path != null && File.Exists(path))
                {
                    openFileDialog.FileName = path;
                    fileNameTextBox.Text = openFileDialog.FileName;
                    analyseClick(null, null);
                }
            }
        }

        private void hasHeaderChanged(object sender, EventArgs e)
        {
            analyseClick(null, null);
        }

        private void chartsMouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            toolTip.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            toolTip.Show($"X:{prop.XValue}\nY:{prop.YValues[0]}", this.chart1, pos.X + 5, pos.Y - 15);
                        }
                    }
                }
            }
        }

        private void chartsMouseClick(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        drawPoint(prop);
                    }
                }
            }
        }

        private void pointGridClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            if (pointGrid.Columns[e.ColumnIndex].Name == "delete")
            {
                DataPoint? point = pointTable.Rows[e.RowIndex]["dataPoint"] as DataPoint;
                undrawPoint(point);
                pointTable.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}