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

        public class MeasureModel
        {
            public System.DateTime DateTime { get; set; }
            public double Value { get; set; }
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
                    Title = "Rain",
                    Values = ChartValues,
                    PointGeometrySize = 18,
                    StrokeThickness = 3
                },
                new LineSeries
                {
                    Title = "Temperature",
                    Values = ChartValues2,
                    PointGeometrySize = 18,
                    StrokeThickness = 3
                }

            };


            cartesianChart1.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => "",
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(20).Ticks
                }
            });

            SetAxisLimits(System.DateTime.Now);


        }
        
        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(20).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(400).Ticks; //we only care about the last 8 seconds
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
            cartesianChart1.ScrollMode = ScrollMode.X;
            cartesianChart1.Pan = PanningOptions.X;
            cartesianChart1.Zoom = ZoomingOptions.Xy;
            cartesianChart1.LegendLocation = LegendLocation.Top;
            gBoxLocation.Text = mf.LocationName;
            txtOut.Text += "Initialised @" + mf.UpdateTimeStamp + " - Temperature: " + mf.Temp[1] + "°C - Rainfall: " + mf.Rain[2] + "mm" + Environment.NewLine + "=======================" + Environment.NewLine;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            txtOut.Text += "Updating" + Environment.NewLine + "=======================" + Environment.NewLine;
            mf.update();
            if (!mf.Rain[1].Equals("Server Error"))
            {
                if (mf.ReadRain == true)
                {
                    gaugeRainfall.Value = Convert.ToDouble(mf.Rain[2]);
                }
                else
                {
                    gaugeRainfall.Value = 0.0;
                }
            }
            else
            {
                gaugeRainfall.Value = 0.0;
                MessageBox.Show("Error in retreiving rainfall data", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!mf.Temp[1].Equals("Server Error"))
            {
                if (mf.ReadTemp == true)
                {
                    gaugeTemp.Value = Convert.ToDouble(mf.Temp[1]);
                }
                else
                {
                    gaugeTemp.Value = 0.0;
                }
            }
            else
            {
                gaugeTemp.Value = 0.0;
                MessageBox.Show("Error in retreiving temperature data", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtOut.Text += "Update @" + mf.UpdateTimeStamp + " - Temperature: " + mf.Temp[1] + "°C - Rainfall: " + mf.Rain[2]+ "mm" +Environment.NewLine + "=======================" + Environment.NewLine;
            //Graphing

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
