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
using TogetherCulture.Analyze;

namespace TogetherCulture
{
    public partial class AnalyzeControl : UserControl
    {
        public Chart eventChart;
        public AnalyzeControl()
        {
            InitializeComponent();
            showChart();
        }

        private void AnalyzeControl_Load(object sender, EventArgs e)
        {
        }


        private void showChart()
        {
            eventChart = new Chart();
            eventChart.Dock = DockStyle.Fill;

            AnallyzeT data = new Trends();
            DataTable datum = data.analyze();

            eventChart.Series.Clear();
            eventChart.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("Event Chart Area");
            eventChart.ChartAreas.Add(chartArea);

            Series series = new Series("Event Bookings")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "event_name",
                YValueMembers = "total_bookings",
                IsValueShownAsLabel = true
            };

            eventChart.DataSource = datum;
            eventChart.Series.Add(series);
            eventChart.DataBind();

            chartArea.AxisX.Title = "Events";
            chartArea.AxisY.Title = "Number of Bookings";
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.Interval = 1;

            this.Controls.Add(eventChart);
        }

    }
}
