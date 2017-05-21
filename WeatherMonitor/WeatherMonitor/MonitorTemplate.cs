using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public partial class MonitorTemplate : Form
    {
        private MonitorFactory mf { get; set; }
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
        }
    }
}
