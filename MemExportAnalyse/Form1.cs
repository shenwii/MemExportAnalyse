using Accessibility;
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
        //最终数据
        private List<int> datas = new List<int>();
        //数据长度
        int dataLen = 0;
        int byteLen = 0;
        public Form1()
        {
            InitializeComponent();
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

        private void analyseClick(object sender, EventArgs e)
        {
            //切割正则表达式
            Regex splitReg = new Regex("\\s+");
            //十六进制匹配正则表达式（这个区分大小写注意）
            Regex hexReg = new Regex("^[0-9abcdef]+$");
            //缓存数据（最大4个）
            Queue<int> numQueue = new Queue<int>();

            //数据初始化
            datas.Clear();
            dataLen = 0;
            byteLen = 0;

            //头帧的一些参数
            bool isVaild = false;
            int headerLen = 0;
            int vaildDataLen = 0;

            //打开文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            DialogResult dialogResult = ofd.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;
            Stream? stream = null;
            StreamReader? streamReader = null;
            try
            {
                stream = ofd.OpenFile();
                streamReader = new StreamReader(stream);
                string? line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    foreach (string data in splitReg.Split(line))
                    {
                        if (!hexReg.IsMatch(data))
                            continue;
                        int len = data.Length;
                        if (dataLen != 0)
                        {
                            //和之前的数据长度不一致
                            if (dataLen != len)
                                continue;
                        }
                        else
                        {
                            //非合法数据
                            if (len != 2 && len != 4 && len != 8)
                                continue;
                            dataLen = len;
                            byteLen = len >> 1;
                        }
                        //转换成数字
                        int num = 0;
                        //转成单个字节放进去
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
                        //删除多余数据
                        int dl = numQueue.Count - 4;
                        while (dl-- > 0)
                            numQueue.Dequeue();
                        if (hasHeader.Checked)
                        {
                            //如果是有效数据
                            if (isVaild)
                            {
                                //先判断是否是头部
                                if (headerLen > 0)
                                {
                                    headerLen -= byteLen;
                                }
                                else
                                {
                                    datas.Add(num);
                                    vaildDataLen -= byteLen;
                                    //数据读完
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
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                chart1.ChartAreas.Add(new ChartArea(""));
                string legend1 = "数据";
                chart1.Series.Add(legend1);
                chart1.Series[legend1].ChartType = SeriesChartType.Line;
                datas.ForEach(num => { chart1.Series[legend1].Points.AddY(num); });
            }
            catch (IOException err)
            {
                MessageBox.Show("读取文件错误：" + err.Message);
            }
            finally
            {
                try
                {
                    if (streamReader != null)
                        streamReader.Close();
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
                                streamWriter.WriteLine(Convert.ToString((byte) num, 8 * byteLen).PadLeft(8 * byteLen, '0'));
                            }
                            else if (byteLen == 2)
                            {
                                streamWriter.WriteLine(Convert.ToString((Int16) num, 8 * byteLen).PadLeft(8 * byteLen, '0'));
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
                MessageBox.Show("写入文件错误：" + err.Message);
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
    }
}