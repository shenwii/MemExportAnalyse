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
            panel1 = new Panel();
            fileNameTextBox = new TextBox();
            fileSelect = new Button();
            analyse = new Button();
            panel2 = new Panel();
            export = new Button();
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
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(931, 75);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // groupSystem
            // 
            groupSystem.Controls.Add(radioHex);
            groupSystem.Controls.Add(radioDec);
            groupSystem.Controls.Add(radioBin);
            groupSystem.Location = new Point(3, 4);
            groupSystem.Margin = new Padding(3, 4, 3, 4);
            groupSystem.Name = "groupSystem";
            groupSystem.Padding = new Padding(3, 4, 3, 4);
            groupSystem.Size = new Size(457, 67);
            groupSystem.TabIndex = 0;
            groupSystem.TabStop = false;
            groupSystem.Text = "输出进制";
            // 
            // radioHex
            // 
            radioHex.AutoSize = true;
            radioHex.Location = new Point(314, 27);
            radioHex.Margin = new Padding(3, 4, 3, 4);
            radioHex.Name = "radioHex";
            radioHex.Size = new Size(94, 24);
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
            radioDec.Location = new Point(166, 27);
            radioDec.Margin = new Padding(3, 4, 3, 4);
            radioDec.Name = "radioDec";
            radioDec.Size = new Size(78, 24);
            radioDec.TabIndex = 0;
            radioDec.TabStop = true;
            radioDec.Text = "十进制";
            radioDec.UseVisualStyleBackColor = true;
            radioDec.Click += systemSet;
            // 
            // radioBin
            // 
            radioBin.AutoSize = true;
            radioBin.Location = new Point(17, 27);
            radioBin.Margin = new Padding(3, 4, 3, 4);
            radioBin.Name = "radioBin";
            radioBin.Size = new Size(78, 24);
            radioBin.TabIndex = 0;
            radioBin.TabStop = true;
            radioBin.Text = "二进制";
            radioBin.UseVisualStyleBackColor = true;
            radioBin.Click += systemSet;
            // 
            // hasHeader
            // 
            hasHeader.Location = new Point(466, 4);
            hasHeader.Margin = new Padding(3, 4, 3, 4);
            hasHeader.Name = "hasHeader";
            hasHeader.Size = new Size(114, 67);
            hasHeader.TabIndex = 1;
            hasHeader.Text = "头祯数据";
            hasHeader.UseVisualStyleBackColor = true;
            hasHeader.CheckStateChanged += hasHeaderChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(fileNameTextBox);
            panel1.Controls.Add(fileSelect);
            panel1.Controls.Add(analyse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 75);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 29);
            panel1.TabIndex = 2;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.AllowDrop = true;
            fileNameTextBox.Dock = DockStyle.Fill;
            fileNameTextBox.Location = new Point(0, 0);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.ReadOnly = true;
            fileNameTextBox.Size = new Size(749, 27);
            fileNameTextBox.TabIndex = 2;
            fileNameTextBox.DragDrop += fileDragDrop;
            fileNameTextBox.DragEnter += fileDragEnter;
            // 
            // fileSelect
            // 
            fileSelect.Dock = DockStyle.Right;
            fileSelect.Location = new Point(749, 0);
            fileSelect.Margin = new Padding(3, 4, 3, 4);
            fileSelect.Name = "fileSelect";
            fileSelect.Size = new Size(91, 29);
            fileSelect.TabIndex = 1;
            fileSelect.Text = "文件";
            fileSelect.UseVisualStyleBackColor = true;
            fileSelect.Click += fileSelectClick;
            // 
            // analyse
            // 
            analyse.Dock = DockStyle.Right;
            analyse.Location = new Point(840, 0);
            analyse.Margin = new Padding(3, 4, 3, 4);
            analyse.Name = "analyse";
            analyse.Size = new Size(91, 29);
            analyse.TabIndex = 0;
            analyse.Text = "解析";
            analyse.UseVisualStyleBackColor = true;
            analyse.Click += analyseClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(export);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 547);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 53);
            panel2.TabIndex = 4;
            // 
            // export
            // 
            export.Dock = DockStyle.Right;
            export.Location = new Point(840, 0);
            export.Margin = new Padding(3, 4, 3, 4);
            export.Name = "export";
            export.Size = new Size(91, 53);
            export.TabIndex = 1;
            export.Text = "导出";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
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
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(691, 443);
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
            panel3.Location = new Point(0, 104);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(931, 443);
            panel3.TabIndex = 7;
            // 
            // pointGrid
            // 
            pointGrid.AllowUserToAddRows = false;
            pointGrid.AllowUserToDeleteRows = false;
            pointGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            pointGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pointGrid.Dock = DockStyle.Right;
            pointGrid.Location = new Point(691, 0);
            pointGrid.Name = "pointGrid";
            pointGrid.ReadOnly = true;
            pointGrid.RowHeadersVisible = false;
            pointGrid.RowHeadersWidth = 51;
            pointGrid.RowTemplate.Height = 29;
            pointGrid.Size = new Size(240, 443);
            pointGrid.TabIndex = 6;
            pointGrid.CellClick += pointGridClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "MemExportAnalyse";
            Load += mainFormLoad;
            flowLayoutPanel1.ResumeLayout(false);
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
    }
}