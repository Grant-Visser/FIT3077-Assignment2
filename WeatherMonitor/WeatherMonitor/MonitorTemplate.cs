using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

namespace WeatherMonitor
{
    public class MeasureModel
    {
        public System.DateTime DateTime { get; set; }
        public double Value { get; set; }
    }
    public partial class MonitorTemplate : Form
    {
        private MonitorFactory mf { get; set; }
        public ChartValues<MeasureModel> ChartValues { get; set; }
        public ChartValues<MeasureModel> ChartValues2 { get; set; }

        public MonitorTemplate()
        {
            InitializeComponent();
            this.Show();
        }

        public MonitorTemplate(MonitorFactory input)//Modified Constructor
        {
            InitializeComponent();
            mf = input;
            this.Show();
            // this is temp measuremodel input <<>>
            var mapper = Mappers.Xy<MeasureModel>()
               .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
               .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            ChartValues = new ChartValues<MeasureModel>();
            ChartValues2 = new ChartValues<MeasureModel>();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = ChartValues,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                },
                new LineSeries
                {
                    Values = ChartValues2,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }

            };


            cartesianChart1.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(20).Ticks
                }
            });

            SetAxisLimits(System.DateTime.Now);


        }

        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(400).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(400).Ticks; //we only care about the last 8 seconds*/
        }

        private void MonitorTemplate_Load(object sender, EventArgs e)
        {
            txtOut.Text = "Monitor for " + mf.LocationName + " has been created." + Environment.NewLine + "Update in 20 Seconds." + Environment.NewLine;
            gaugeRainfall.Value = Convert.ToDouble(mf.Rain[2]);
            gaugeTemp.Value = Convert.ToDouble(mf.Temp[1]);
            gaugeRainfall.Uses360Mode = true;
            gaugeTemp.Uses360Mode = true;
            gaugeTemp.To = 40;
            gaugeRainfall.To = 3;
            gBoxLocation.Text = mf.LocationName;
            txtOut.Text += "Initialised @" + mf.UpdateTimeStamp + " - Temperature: " + mf.Temp[1] + "°C - Rainfall: " + mf.Rain[2] + "mm" + Environment.NewLine + "=======================" + Environment.NewLine;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            txtOut.Text += "Updating" + Environment.NewLine + "=======================" + Environment.NewLine;
            mf.update();
            gaugeRainfall.Value = Convert.ToDouble(mf.Rain[2]);
            gaugeTemp.Value = Convert.ToDouble(mf.Temp[1]);
            txtOut.Text += "Update @" + mf.UpdateTimeStamp + " - Temperature: " + mf.Temp[1] + "°C - Rainfall: " + mf.Rain[2]+ "mm" +Environment.NewLine + "=======================" + Environment.NewLine;

            var now = System.DateTime.Now;

            ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = Convert.ToDouble(mf.Rain[2])
            });

            ChartValues2.Add(new MeasureModel
            {
                DateTime = now,
                Value = Convert.ToDouble(mf.Temp[1])
            });

            SetAxisLimits(now);
        }
    }
}
