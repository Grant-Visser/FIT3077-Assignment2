using System;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public partial class lab : Form
    {
        //Instance Variables
        LocationCollection locCol = new LocationCollection();
        MonitorCollection monCol = new MonitorCollection();

        public lab() //Constructor
        {
            InitializeComponent();//initialises the form

            try//tries to add all the locations from the web server to the cboxlocation form object
            {
                cBoxLocation.Items.Clear();//Clearing the cbox
                locCol.clear();//Clearing the location array(just in case)
                string[] location;
                WebInterface melbourneWeatherService = new WebInterface(); //Creating an instance of the weather interface I wrote.
                location = melbourneWeatherService.getLocations();//Pulling string array of locations from server
                foreach (string item in location)
                {
                    locCol.addToCollection(new LocationFactory(item));//Create new location factory element and add it to the Location collection
                    cBoxLocation.Items.Add(item);//Adding the location to the interface(with the same index as above! :D)
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e);//Outputting any issues if failed.
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try//trying to show data from monitors on the GUI.
            {
                Console.Out.WriteLine(lbMonitors.SelectedItem + " monitor selected"); // Confirming logic to console
                MonitorFactory mf = monCol.MonitorArray[lbMonitors.SelectedIndex]; //Assigning the monitor corresponding to the one created and then selected by the user. 
                //Updating Outputs
                Console.Out.WriteLine(mf.LocationName + "   -   " + mf.Rain[1] + "mm   -   " + mf.Temp[1] + "°c -  @" + mf.TimeStamp);
                lblLocation.Text = mf.LocationName;
                lblRainfall.Text = mf.Rain[1] + " mm of rain";
                lblTemperature.Text = mf.Temp[1] + "°C";
                lblLastUpdated.Text = mf.TimeStamp;
            }
            catch (Exception e3)//Catching any errors along the way
            {
                Console.Out.WriteLine(e3);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try //Trying to add a monitor to the monitor collection
            {
                if (!(cBoxLocation.Text.Equals("Please Make a Selection")))//If they have selected something
                {
                    LocationFactory lf = locCol.LocationArray[cBoxLocation.SelectedIndex]; //assigning a location factory to the one selected by the user from the drop down.
                    monCol.addToCollection(new MonitorFactory(lf, cbxRain.Checked, cbxTemp.Checked));//Creating a new monitor factory element and adding it to the collection.
                    lbMonitors.Items.Add(lf.LocationName + ": Temp-" + cbxTemp.Checked + " Rain-" + cbxRain.Checked);//Adding the monitor to the visual list.
                    lbMonitors.SelectedIndex = lbMonitors.Items.Count - 1;
                }
                else
                {
                    Console.Out.WriteLine("Please select a location!");
                    MessageBox.Show("Please select a location from the location drop down menu", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception e2)
            {
                Console.Out.WriteLine(e2);//Output errors
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Monitors will now all update", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            monCol.update();//When the timer reaches 5mins, it updates every element in the monitorCollection
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                monCol.MonitorArray.RemoveAt(lbMonitors.SelectedIndex);
                lbMonitors.Items.RemoveAt(lbMonitors.SelectedIndex);
                lbMonitors.SelectedIndex = 0;
                MessageBox.Show("Monitor Deleted", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Error in removing monitor", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Out.WriteLine("Error in removing Monitor: " +e3);
            }
        }
    }
}
