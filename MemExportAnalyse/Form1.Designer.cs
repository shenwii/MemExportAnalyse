namespace MemExportAnalyse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupSystem = new GroupBox();
            radioHex = new RadioButton();
            radioDec = new RadioButton();
            radioBin = new RadioButton();
            hasHeader = new CheckBox();
            checkBoxCharts = new CheckBox();
            label1 = new Label();
            textHeader = new TextBox();
            label2 = new Label();
            textHeaderLen = new TextBox();
            label3 = new Label();
            textMin = new TextBox();
            label4 = new Label();
            textMax = new TextBox();
            panel1 = new Panel();
            fileNameTextBox = new TextBox();
            fileSelect = new Button();
            analyse = new Button();
            panel2 = new Panel();
            export = new Button();
            progressBar1 = new ProgressBar();
            openFileDialog = new OpenFileDialog();
            toolTip = new ToolTip(components);
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            pointGrid = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            groupSystem.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pointGrid).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(groupSystem);
            flowLayoutPanel1.Controls.Add(hasHeader);
            flowLayoutPanel1.Controls.Add(checkBoxCharts);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textHeader);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textHeaderLen);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textMin);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textMax);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(986, 56);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // groupSystem
            // 
            groupSystem.Controls.Add(radioHex);
            groupSystem.Controls.Add(radioDec);
            groupSystem.Controls.Add(radioBin);
            groupSystem.Location = new Point(3, 3);
            groupSystem.Name = "groupSystem";
            groupSystem.Size = new Size(277, 50);
            groupSystem.TabIndex = 0;
            groupSystem.TabStop = false;
            groupSystem.Text = "输出进制";
            // 
            // radioHex
            // 
            radioHex.AutoSize = true;
            radioHex.Location = new Point(182, 20);
            radioHex.Name = "radioHex";
            radioHex.Size = new Size(77, 19);
            radioHex.TabIndex = 0;
            radioHex.TabStop = true;
            radioHex.Text = "十六进制";
            radioHex.UseVisualStyleBackColor = true;
            radioHex.Click += systemSet;
            // 
            // radioDec
            // 
            radioDec.AutoSize = true;
            radioDec.Checked = true;
            radioDec.Location = new Point(100, 20);
            radioDec.Name = "radioDec";
            radioDec.Size = new Size(64, 19);
            radioDec.TabIndex = 0;
            radioDec.TabStop = true;
            radioDec.Text = "十进制";
            radioDec.UseVisualStyleBackColor = true;
            radioDec.Click += systemSet;
            // 
            // radioBin
            // 
            radioBin.AutoSize = true;
            radioBin.Location = new Point(15, 20);
            radioBin.Name = "radioBin";
            radioBin.Size = new Size(64, 19);
            radioBin.TabIndex = 0;
            radioBin.TabStop = true;
            radioBin.Text = "二进制";
            radioBin.UseVisualStyleBackColor = true;
            radioBin.Click += systemSet;
            // 
            // hasHeader
            // 
            hasHeader.Dock = DockStyle.Left;
            hasHeader.Location = new Point(286, 3);
            hasHeader.Name = "hasHeader";
            hasHeader.Size = new Size(100, 50);
            hasHeader.TabIndex = 1;
            hasHeader.Text = "头祯数据";
            hasHeader.UseVisualStyleBackColor = true;
            hasHeader.CheckStateChanged += hasHeaderChanged;
            // 
            // checkBoxCharts
            // 
            checkBoxCharts.Checked = true;
            checkBoxCharts.CheckState = CheckState.Checked;
            checkBoxCharts.Dock = DockStyle.Left;
            checkBoxCharts.Location = new Point(392, 3);
            checkBoxCharts.Name = "checkBoxCharts";
            checkBoxCharts.Size = new Size(100, 50);
            checkBoxCharts.TabIndex = 2;
            checkBoxCharts.Text = "画折线图";
            checkBoxCharts.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(498, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 56);
            label1.TabIndex = 3;
            label1.Text = "头帧";
            label1.Visible = false;
            // 
            // textHeader
            // 
            textHeader.Dock = DockStyle.Left;
            textHeader.Location = new Point(537, 3);
            textHeader.Name = "textHeader";
            textHeader.Size = new Size(73, 23);
            textHeader.TabIndex = 4;
            textHeader.Text = "fdfdfdfd";
            textHeader.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(616, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 56);
            label2.TabIndex = 5;
            label2.Text = "头长度";
            label2.Visible = false;
            // 
            // textHeaderLen
            // 
            textHeaderLen.Dock = DockStyle.Left;
            textHeaderLen.Location = new Point(668, 3);
            textHeaderLen.Name = "textHeaderLen";
            textHeaderLen.Size = new Size(47, 23);
            textHeaderLen.TabIndex = 6;
            textHeaderLen.Text = "24";
            textHeaderLen.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(721, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 56);
            label3.TabIndex = 7;
            label3.Text = "帧范围";
            // 
            // textMin
            // 
            textMin.Dock = DockStyle.Left;
            textMin.Location = new Point(773, 3);
            textMin.Name = "textMin";
            textMin.Size = new Size(53, 23);
            textMin.TabIndex = 8;
            textMin.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(832, 0);
            label4.Name = "label4";
            label4.Size = new Size(15, 56);
            label4.TabIndex = 9;
            label4.Text = "~";
            // 
            // textMax
            // 
            textMax.Dock = DockStyle.Left;
            textMax.Location = new Point(853, 3);
            textMax.Name = "textMax";
            textMax.Size = new Size(53, 23);
            textMax.TabIndex = 10;
            textMax.Text = "8192";
            // 
            // panel1
            // 
            panel1.Controls.Add(fileNameTextBox);
            panel1.Controls.Add(fileSelect);
            panel1.Controls.Add(analyse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 22);
            panel1.TabIndex = 2;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.AllowDrop = true;
            fileNameTextBox.Dock = DockStyle.Fill;
            fileNameTextBox.Location = new Point(0, 0);
            fileNameTextBox.Margin = new Padding(3, 2, 3, 2);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.ReadOnly = true;
            fileNameTextBox.Size = new Size(826, 23);
            fileNameTextBox.TabIndex = 2;
            fileNameTextBox.DragDrop += fileDragDrop;
            fileNameTextBox.DragEnter += fileDragEnter;
            // 
            // fileSelect
            // 
            fileSelect.Dock = DockStyle.Right;
            fileSelect.Location = new Point(826, 0);
            fileSelect.Name = "fileSelect";
            fileSelect.Size = new Size(80, 22);
            fileSelect.TabIndex = 1;
            fileSelect.Text = "文件";
            fileSelect.UseVisualStyleBackColor = true;
            fileSelect.Click += fileSelectClick;
            // 
            // analyse
            // 
            analyse.Dock = DockStyle.Right;
            analyse.Location = new Point(906, 0);
            analyse.Name = "analyse";
            analyse.Size = new Size(80, 22);
            analyse.TabIndex = 0;
            analyse.Text = "解析";
            analyse.UseVisualStyleBackColor = true;
            analyse.Click += analyseClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(export);
            panel2.Controls.Add(progressBar1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 50);
            panel2.TabIndex = 4;
            // 
            // export
            // 
            export.Dock = DockStyle.Right;
            export.Location = new Point(906, 20);
            export.Name = "export";
            export.Size = new Size(80, 30);
            export.TabIndex = 1;
            export.Text = "导出";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(0, 0);
            progressBar1.Maximum = 1000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(986, 20);
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.FileOk += fileIsSelected;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(776, 381);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            chart1.MouseClick += chartsMouseClick;
            chart1.MouseMove += chartsMouseMove;
            // 
            // panel3
            // 
            panel3.Controls.Add(chart1);
            panel3.Controls.Add(pointGrid);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(986, 381);
            panel3.TabIndex = 7;
            // 
            // pointGrid
            // 
            pointGrid.AllowUserToAddRows = false;
            pointGrid.AllowUserToDeleteRows = false;
            pointGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pointGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pointGrid.Dock = DockStyle.Right;
            pointGrid.Location = new Point(776, 0);
            pointGrid.Margin = new Padding(3, 2, 3, 2);
            pointGrid.Name = "pointGrid";
            pointGrid.ReadOnly = true;
            pointGrid.RowHeadersVisible = false;
            pointGrid.RowTemplate.Height = 29;
            pointGrid.Size = new Size(210, 381);
            pointGrid.TabIndex = 6;
            pointGrid.CellClick += pointGridClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 509);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "MemExportAnalyse 1.0.6";
            Load += mainFormLoad;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupSystem.ResumeLayout(false);
            groupSystem.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pointGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button analyse;
        private GroupBox groupSystem;
        private RadioButton radioBin;
        private RadioButton radioHex;
        private RadioButton radioDec;
        private CheckBox hasHeader;
        private Panel panel2;
        private Button export;
        private TextBox fileNameTextBox;
        private Button fileSelect;
        private OpenFileDialog openFileDialog;
        private ToolTip toolTip;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel3;
        private DataGridView pointGrid;
        private ProgressBar progressBar1;
        private CheckBox checkBoxCharts;
        private Label label1;
        private TextBox textHeader;
        private Label label2;
        private TextBox textHeaderLen;
        private Label label3;
        private TextBox textMin;
        private Label label4;
        private TextBox textMax;
    }
}