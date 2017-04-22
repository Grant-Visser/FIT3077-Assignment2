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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] test = { "Moscow", "China", "Cambodia", "Khazakstan"};
            LocationCollection testCol = new LocationCollection(test);
            Console.Out.WriteLine(testCol.getAreas());
        }
    }
}
