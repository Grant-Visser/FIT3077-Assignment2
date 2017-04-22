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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] test = { "Moscow", "China", "Cambodia", "Khazakstan"};//Just a temporary list
            LocationCollection testCol = new LocationCollection(test);//Creating a new Location collection with objects names provided by the temp list
            Console.Out.WriteLine(testCol.getAreas());//Outputting a formatted string to console
        }
    }
}
