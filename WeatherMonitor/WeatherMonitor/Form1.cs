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
        string[] test = { "Moscow", "China", "Cambodia", "Khazakstan" };//Just a temporary list. web service goes here
        MonitorCollection monCol = new MonitorCollection();
        public frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocationCollection testCol = new LocationCollection(test);//Creating a new Location collection with objects names provided by the temp list
            Console.Out.WriteLine(testCol.getAreas());//Outputting a formatted string to console
            monCol.addToCollection(new LocationFactory(test[0]));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            monCol.update();//Updating all elements in Monitor Collection
        }
    }
}
