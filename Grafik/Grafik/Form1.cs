using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(trackBarA.Value) / 10.0;
            double b = Convert.ToDouble(trackBarB.Value) / 10.0;

            chart1.ChartAreas[0].AxisX.Minimum = -10;
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 2;

            Series series = new Series("y=a*sin(bx)");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;

            for (double x = -10; x <= 10; x += 0.01)
            {
                double y = a * Math.Sin(b * x);
                series.Points.AddXY(x, y);
            }
            chart1.Series.Clear();
            chart1.Series.Add(series);

            trackBarA.Scroll += new EventHandler(trackBarA_Scroll);
            trackBarB.Scroll += new EventHandler(trackBarB_Scroll);
        }
        public void trackBarA_Scroll(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(trackBarA.Value) / 10.0;
            double b = Convert.ToDouble(trackBarB.Value) / 10.0;

            Series series = new Series("y=a*sin(bx)");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            for (double x = -10; x <= 10; x += 0.01)
            {
                double y = a * Math.Sin(b * x);
                series.Points.AddXY(x, y);
            }

            chart1.Series.Clear();
            chart1.Series.Add(series);

            chart1.Invalidate();

        }
        public void trackBarB_Scroll(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(trackBarA.Value) / 10.0;
            double b = Convert.ToDouble(trackBarB.Value) / 10.0;

            Series series = new Series("y=a*sin(bx)");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            for (double x = -10; x <= 10; x += 0.01)
            {
                double y = a * Math.Sin(b * x);
                series.Points.AddXY(x, y);
            }

            chart1.Series.Clear();
            chart1.Series.Add(series);

            chart1.Invalidate();
        }
    }
}
