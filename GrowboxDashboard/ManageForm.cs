using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media;

namespace GrowboxDashboard
{
    public partial class ManageForm : Form
    {
        int AllowedPoints = 100;

        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            /* Настройки главного графика */

            lightChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 0.0 },
                ScalesYAt = 0,
                Stroke = new SolidColorBrush { Color = System.Windows.Media.Color.FromRgb(209, 0, 0) },
                Fill = new SolidColorBrush { Color = System.Windows.Media.Color.FromArgb(100, 209, 0, 0) },
                PointGeometry = null,
                PointGeometrySize = 0,
                StrokeThickness = 1,
                LineSmoothness = 1
            });

            lightChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 0.0 },
                ScalesYAt = 0,
                Stroke = new SolidColorBrush { Color = System.Windows.Media.Color.FromRgb(0, 209, 0) },
                Fill = new SolidColorBrush { Color = System.Windows.Media.Color.FromArgb(100, 0, 209, 0) },
                PointGeometry = null,
                PointGeometrySize = 0,
                StrokeThickness = 1,
                LineSmoothness = 1
            });

            lightChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 0.0 },
                ScalesYAt = 0,
                Stroke = new SolidColorBrush { Color = System.Windows.Media.Color.FromRgb(0, 0, 209) },
                Fill = new SolidColorBrush { Color = System.Windows.Media.Color.FromArgb(100, 0, 0, 209) },
                PointGeometry = null,
                PointGeometrySize = 0,
                StrokeThickness = 1,
                LineSmoothness = 1
            });

            for (int i = 0; i < 3; i++)
            {
                lightChart.Series[i].Values.Clear();
            }

            lightChart.AxisY.Add(new Axis { });

            lightChart.AxisY[0].MinValue = 0.0;
            lightChart.AxisY[0].MaxValue = 100.0;

            lightChart.Zoom = ZoomingOptions.X;

            /******************************/

            mainTimer.Enabled = true;
            mainTimer.Start();
        }

        private void AddNewValueToMainChart(double val, int seriesId)
        {
            if (lightChart.Series[seriesId].Values.Count == AllowedPoints)
            {
                lightChart.Series[seriesId].Values.RemoveAt(0);
            }

            lightChart.Series[seriesId].Values.Add(val);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            AddNewValueToMainChart(redLightTrack.Value,   0);
            AddNewValueToMainChart(greenLightTrack.Value, 1);
            AddNewValueToMainChart(blueLightTrack.Value,  2);
        }
    }
}
