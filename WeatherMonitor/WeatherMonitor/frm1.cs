using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public partial class lab : Form
    {
        //Variaable Declarations
        LocationCollection locCol = new LocationCollection();
        MonitorCollection monCol = new MonitorCollection();

        //Helper Methods
        private bool updateLocations()
        {
            try
            {
                cBoxLocation.Items.Clear();
                locCol.clear();
                string[] location;
                WebInterface melbourneWeatherService = new WebInterface();
                location = melbourneWeatherService.getLocations();
                foreach (string item in location)
                {
                    locCol.addToCollection(new LocationFactory(item));
                    cBoxLocation.Items.Add(item);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e);
                return false;
            }
        }

        public lab() //Constructor
        {
            InitializeComponent();
            updateLocations(); //Constructor updates the locations available for selection
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //monCol.update();//Updating all elements in Monitor Collection
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Out.WriteLine(lbMonitors.SelectedItem + " Item");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cBoxLocation.Text.Equals("Please Make a Selection")))
                {
                    bool found = false;
                    int i = 0;
                    LocationFactory lf = null;
                    //Boolean search constrained to the size of the array (number of lactaion factories) contained within Location Colelction
                    while (!found && i<locCol.LocationArray.Count)
                    {
                        if (locCol.LocationArray[i].LocationName.Equals(cBoxLocation.SelectedItem))
                        {
                            Console.Out.WriteLine("Selected location was found in the location collection!");
                            found = true;
                            lf = locCol.LocationArray[i];
                            Console.Out.WriteLine(lf.LocationName);
                        }
                        else
                        {
                            i++;
                        }
                    }
                    if (!(found))
                    {
                        Console.Out.WriteLine("Selected location not found in the location collection");
                        MessageBox.Show("Something Horrible Happened. The Application will now exit", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    monCol.addToCollection(new MonitorFactory(lf, cbxRain.Checked, cbxTemp.Checked));
                    lbMonitors.Items.Add(lf.LocationName);
                    //MonitorFactory test = new MonitorFactory()
                }
                else
                {
                    Console.Out.WriteLine("Please select a location!");
                    MessageBox.Show("Please select a location from the location drop down menu", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }catch (Exception e2)
            {
                Console.Out.WriteLine(e2);
            }
        }
    }
}
