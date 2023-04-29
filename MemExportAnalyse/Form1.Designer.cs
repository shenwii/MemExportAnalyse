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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupSystem = new GroupBox();
            radioHex = new RadioButton();
            radioDec = new RadioButton();
            radioBin = new RadioButton();
            hasHeader = new CheckBox();
            panel1 = new Panel();
            analyse = new Button();
            panel2 = new Panel();
            export = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            flowLayoutPanel1.SuspendLayout();
            groupSystem.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(groupSystem);
            flowLayoutPanel1.Controls.Add(hasHeader);
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
            // 
            // panel1
            // 
            panel1.Controls.Add(analyse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 40);
            panel1.TabIndex = 2;
            // 
            // analyse
            // 
            analyse.Dock = DockStyle.Right;
            analyse.Location = new Point(735, 0);
            analyse.Name = "analyse";
            analyse.Size = new Size(80, 40);
            analyse.TabIndex = 0;
            analyse.Text = "解析";
            analyse.UseVisualStyleBackColor = true;
            analyse.Click += analyseClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(export);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 40);
            panel2.TabIndex = 4;
            // 
            // export
            // 
            export.Dock = DockStyle.Right;
            export.Location = new Point(735, 0);
            export.Name = "export";
            export.Size = new Size(80, 40);
            export.TabIndex = 1;
            export.Text = "导出";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(0, 96);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(815, 314);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(chart1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "MemExportAnalyse";
            Load += mainFormLoad;
            flowLayoutPanel1.ResumeLayout(false);
            groupSystem.ResumeLayout(false);
            groupSystem.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button export;
    }
}