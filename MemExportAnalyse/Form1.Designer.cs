﻿namespace MemExportAnalyse
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
            errorProvider1 = new ErrorProvider(components);
            flowLayoutPanel1.SuspendLayout();
            groupSystem.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pointGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(groupSystem);
            flowLayoutPanel1.Controls.Add(hasHeader);
            flowLayoutPanel1.Controls.Add(checkBoxCharts);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(815, 56);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // groupSystem
            // 
            groupSystem.Controls.Add(radioHex);
            groupSystem.Controls.Add(radioDec);
            groupSystem.Controls.Add(radioBin);
            groupSystem.Location = new Point(3, 3);
            groupSystem.Name = "groupSystem";
            groupSystem.Size = new Size(400, 50);
            groupSystem.TabIndex = 0;
            groupSystem.TabStop = false;
            groupSystem.Text = "输出进制";
            // 
            // radioHex
            // 
            radioHex.AutoSize = true;
            radioHex.Location = new Point(275, 20);
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
            radioDec.Location = new Point(145, 20);
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
            hasHeader.Location = new Point(409, 3);
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
            checkBoxCharts.Location = new Point(515, 3);
            checkBoxCharts.Name = "checkBoxCharts";
            checkBoxCharts.Size = new Size(100, 50);
            checkBoxCharts.TabIndex = 2;
            checkBoxCharts.Text = "画折线图";
            checkBoxCharts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(fileNameTextBox);
            panel1.Controls.Add(fileSelect);
            panel1.Controls.Add(analyse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 22);
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
            fileNameTextBox.Size = new Size(655, 23);
            fileNameTextBox.TabIndex = 2;
            fileNameTextBox.DragDrop += fileDragDrop;
            fileNameTextBox.DragEnter += fileDragEnter;
            // 
            // fileSelect
            // 
            fileSelect.Dock = DockStyle.Right;
            fileSelect.Location = new Point(655, 0);
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
            analyse.Location = new Point(735, 0);
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
            panel2.Location = new Point(0, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 50);
            panel2.TabIndex = 4;
            // 
            // export
            // 
            export.Dock = DockStyle.Right;
            export.Location = new Point(735, 20);
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
            progressBar1.Size = new Size(815, 20);
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
            chart1.Size = new Size(605, 322);
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
            panel3.Size = new Size(815, 322);
            panel3.TabIndex = 7;
            // 
            // pointGrid
            // 
            pointGrid.AllowUserToAddRows = false;
            pointGrid.AllowUserToDeleteRows = false;
            pointGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pointGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pointGrid.Dock = DockStyle.Right;
            pointGrid.Location = new Point(605, 0);
            pointGrid.Margin = new Padding(3, 2, 3, 2);
            pointGrid.Name = "pointGrid";
            pointGrid.ReadOnly = true;
            pointGrid.RowHeadersVisible = false;
            pointGrid.RowTemplate.Height = 29;
            pointGrid.Size = new Size(210, 322);
            pointGrid.TabIndex = 6;
            pointGrid.CellClick += pointGridClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "MemExportAnalyse 1.0.4";
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ErrorProvider errorProvider1;
        private CheckBox checkBoxCharts;
    }
}