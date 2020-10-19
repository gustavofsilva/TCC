using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceView
{
    public partial class FormPerformanceView : Form
    {
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;

        public FormPerformanceView()
        {
            InitializeComponent();

            Text = "Gráfico de Performance";
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            chart1.Legends.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
            chart1.ChartAreas[0].AxisY.Maximum = 8000;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.BackColor = Color.FromArgb(203, 223, 240);
            chart1.BackSecondaryColor = Color.White;

        }
        int x=0;
       
        public void startTimer()
        {
            chart1.Enabled = true;
        }
        public void stopTimer()
        {
            chart1.Enabled = false;
        }

        public double getCurrentCpuUsage()
        {
            return cpuCounter.NextValue();
        }

        public double getAvailableRAM()
        {
            return ramCounter.NextValue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 7)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Update();
            }
            chart1.Series[0].Points.AddXY(x++, 8000 - getAvailableRAM());

            chart1.Series[0].Points[chart1.Series[0].Points.Count-1].Label = (8000 - getAvailableRAM()).ToString();

            if (Convert.ToInt32(labelMaxResult.Text) < 8000 - getAvailableRAM())
            {
                labelMaxResult.Text = (8000 - getAvailableRAM()).ToString();

            }

        }

        public void startForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread _thread = new Thread(() =>
            {
                Application.Run(new FormPerformanceView());
            });
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }
    }
}
