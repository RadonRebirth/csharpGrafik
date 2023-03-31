namespace Grafik
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(59, 39);
            chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(464, 325);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // trackBarA
            // 
            trackBarA.Location = new Point(644, 157);
            trackBarA.Minimum = -10;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(104, 45);
            trackBarA.TabIndex = 1;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(644, 232);
            trackBarB.Minimum = -10;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(104, 45);
            trackBarB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(547, 166);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 2;
            label1.Text = "Значение a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(547, 232);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 2;
            label2.Text = "Значение b";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private Label label1;
        private Label label2;
    }
}