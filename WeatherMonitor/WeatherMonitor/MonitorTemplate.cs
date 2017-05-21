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
            gaugeRainfall.Value = Convert.ToDouble(mf.Rain[1]);
            gaugeTemp.Value = Convert.ToDouble(mf.Temp[1]);
        }

       

       
    }
}
