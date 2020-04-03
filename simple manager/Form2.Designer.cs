namespace simple_manager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pCpu = new System.Diagnostics.PerformanceCounter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.labelcpu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRAM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pDisk = new System.Diagnostics.PerformanceCounter();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.labeldisk = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(130, 148);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(515, 30);
            this.progressBar1.TabIndex = 0;
            // 
            // pCpu
            // 
            this.pCpu.CategoryName = "processor";
            this.pCpu.CounterName = "% Processor Time";
            this.pCpu.InstanceName = "_Total";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(130, 12);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "CPU";
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(570, 130);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU";
            // 
            // labelcpu
            // 
            this.labelcpu.AutoSize = true;
            this.labelcpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcpu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelcpu.Location = new System.Drawing.Point(651, 148);
            this.labelcpu.Name = "labelcpu";
            this.labelcpu.Size = new System.Drawing.Size(37, 24);
            this.labelcpu.TabIndex = 3;
            this.labelcpu.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBar2.Location = new System.Drawing.Point(130, 323);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(515, 28);
            this.progressBar2.TabIndex = 4;
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(130, 184);
            this.chart2.Name = "chart2";
            series5.BackSecondaryColor = System.Drawing.Color.White;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.White;
            series5.Name = "MEMORY";
            series5.ShadowColor = System.Drawing.Color.White;
            series5.YValuesPerPoint = 4;
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(570, 133);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelRAM.Location = new System.Drawing.Point(651, 327);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(37, 24);
            this.labelRAM.TabIndex = 6;
            this.labelRAM.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "MEMORY";
            // 
            // pDisk
            // 
            this.pDisk.CategoryName = "PhysicalDisk";
            this.pDisk.CounterName = "Disk Transfers/sec";
            this.pDisk.InstanceName = "0 C: F: G:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(130, 495);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(510, 26);
            this.progressBar3.TabIndex = 8;
            // 
            // labeldisk
            // 
            this.labeldisk.AutoSize = true;
            this.labeldisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldisk.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labeldisk.Location = new System.Drawing.Point(663, 495);
            this.labeldisk.Name = "labeldisk";
            this.labeldisk.Size = new System.Drawing.Size(37, 24);
            this.labeldisk.TabIndex = 9;
            this.labeldisk.Text = "0%";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(130, 357);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Legend = "Legend1";
            series6.Name = "DISK";
            series6.YValuesPerPoint = 2;
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(570, 132);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(8, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Disk";
            // 
            // btnrun
            // 
            this.btnrun.BackColor = System.Drawing.Color.SkyBlue;
            this.btnrun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrun.Location = new System.Drawing.Point(16, 502);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(51, 20);
            this.btnrun.TabIndex = 12;
            this.btnrun.Text = "close";
            this.btnrun.UseVisualStyleBackColor = false;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(768, 534);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.labeldisk);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.labelcpu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P E R F O R M A N C E";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Diagnostics.PerformanceCounter pCpu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelcpu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.PerformanceCounter pDisk;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label labeldisk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnrun;
    }
}