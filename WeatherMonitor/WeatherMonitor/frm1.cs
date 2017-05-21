using System;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public partial class lab : Form
    {
        //Instance Variables
        LocationCollection locCol5m = new LocationCollection();
        LocationCollection locCol20s = new LocationCollection();
        MonitorCollection monCol5m = new MonitorCollection();
        MonitorCollection monCol20s = new MonitorCollection();

        public lab() //Constructor
        {
            InitializeComponent();//initialises the form
            gaugeRainfall.Uses360Mode = true;
            gaugeTemp.Uses360Mode = true;
            gaugeTemp.To = 40;
            gaugeRainfall.To = 3;

            locCol5m.LocationArray.Clear();//initialises the array
            locCol20s.LocationArray.Clear();//initialises the array
            try//tries to add all the locations from the web server to the cboxlocation form object
            {
                cBoxLocation.Items.Clear();//Clearing the cbox
                string[] location;
                Console.Out.WriteLine("Pulling Locations 20s");
                TimeLapse timeLapse = new TimeLapse();//Creating an instance of the weather interface I wrote.
                location = timeLapse.getLocations();//Pulling string array of locations from server
                foreach (string item in location)
                {
                    locCol20s.addToCollection(new LocationFactory(item));//Create new location factory element and add it to the Location collection
                }
                location = null; //Resetting the array
                Console.Out.WriteLine("Pulling Locations 5 min");
                WebInterface melbourneWeatherService = new WebInterface(); //Creating an instance of the weather interface I wrote.
                location = melbourneWeatherService.getLocations();//Pulling string array of locations from server
                foreach (string item in location)
                {
                    locCol5m.addToCollection(new LocationFactory(item));//Create new location factory element and add it to the Location collection
                    cBoxLocation.Items.Add(item);//Adding the location to the interface(with the same index as above! :D)
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not retrieve location information\n" + e, "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Out.WriteLine(e);
                Application.Exit();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gaugeTemp.Value = 0;
            gaugeRainfall.Value = 0;
            gaugeRainfall.Update();
            gaugeTemp.Update();
            try//trying to show data from monitors on the GUI.
            {
                Console.Out.WriteLine(lbMonitors.SelectedItem + " monitor selected"); // Confirming logic to console
                MonitorFactory mf = monCol5m.MonitorArray[lbMonitors.SelectedIndex]; //Assigning the monitor corresponding to the one created and then selected by the user. 
                //Updating Outputs
                Console.Out.WriteLine(mf.LocationName + "   -   " + mf.Rain[1] + "mm   -   " + mf.Temp[1] + "°c -  @" + mf.TimeStamp);
                if (!mf.Rain[1].Equals("Server Error"))
                {
                    if (mf.ReadRain == true)
                    {
                        gaugeRainfall.Value = Convert.ToDouble(mf.Rain[1])  ; 
                    }
                    else
                    {
                        gaugeRainfall.Value = 0.0;
                    }
                }
                else
                {
                    gaugeRainfall.Value = Convert.ToDouble("0");
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
                gBoxLocation.Text = mf.LocationName;
                gBoxLastUpdated.Text = mf.UpdateTimeStamp;


            }
            catch (Exception e3)//Catching any errors along the way
            {
                Console.Out.WriteLine(e3);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gaugeTemp.Value = 0;
            gaugeRainfall.Value = 0;
            gaugeRainfall.Update();
            gaugeTemp.Update();
            try //Trying to add a monitor to the monitor collection
            {
                if (!(cBoxLocation.Text.Equals("Please Make a Selection")))//If they have selected something
                {
                    if (rbx5min.Checked)
                    {
                        LocationFactory lf = locCol5m.LocationArray[cBoxLocation.SelectedIndex]; //assigning a location factory to the one selected by the user from the drop down.
                        monCol5m.addToCollection(new MonitorFactory(lf, cbxRain.Checked, cbxTemp.Checked,1));//Creating a new monitor factory element and adding it to the collection.
                        lbMonitors.Items.Add(lf.LocationName + ": Temp-" + cbxTemp.Checked + " Rain-" + cbxRain.Checked);//Adding the monitor to the visual list.
                        lbMonitors.SelectedIndex = lbMonitors.Items.Count - 1;
                    }
                    else
                    {
                        LocationFactory lf = locCol20s.LocationArray[cBoxLocation.SelectedIndex]; //assigning a location factory to the one selected by the user from the drop down.
                        MonitorFactory mf = new MonitorFactory(lf, cbxRain.Checked, cbxTemp.Checked,2);
                        monCol20s.addToCollection(mf);//Creating a new monitor factory element and adding it to the collection.
                        lb20s.Items.Add(lf.LocationName + ": Temp-" + cbxTemp.Checked + " Rain-" + cbxRain.Checked);//Adding the monitor to the visual list.
                        lb20s.SelectedIndex = lb20s.Items.Count - 1;
                    }
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
            if (monCol5m.MonitorArray.Count > 0)
            {
                monCol5m.update();//When the timer reaches 5mins, it updates every element in the monitorCollection
                MessageBox.Show("Monitors will now all update", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                monCol5m.MonitorArray.RemoveAt(lbMonitors.SelectedIndex);
                lbMonitors.Items.RemoveAt(lbMonitors.SelectedIndex);
                lbMonitors.SelectedIndex = 0;
                MessageBox.Show("Monitor Deleted", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Error in removing monitor", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Out.WriteLine("Error in removing Monitor: " + e3);
            }
        }

        private void lb20s_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form createdForm = new MonitorTemplate(monCol20s.MonitorArray[lb20s.SelectedIndex]);
        }

        private void rbxHandler()
        {
            cBoxLocation.Items.Clear();//Clearing the checkbox
            cBoxLocation.Text = "Please Make a Selection";
            if (rbx20s.Checked == true)
            {
                int test = locCol20s.LocationArray.Count;
                Console.Out.WriteLine(test);
                foreach (LocationFactory lf in locCol20s.LocationArray)
                {
                    cBoxLocation.Items.Add(lf.LocationName);
                }
                //MessageBox.Show("Locations Loaded", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int test = locCol20s.LocationArray.Count;
                Console.Out.WriteLine(test);
                foreach (LocationFactory lf in locCol5m.LocationArray)
                {
                    cBoxLocation.Items.Add(lf.LocationName);
                }
                //MessageBox.Show("Locations Loaded", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbx20s_Click(object sender, EventArgs e)
        {
            rbxHandler();
        }

        private void rbx5min_Click(object sender, EventArgs e)
        {
            rbxHandler();
        }

        private void btnRemoveForms_Click(object sender, EventArgs e)
        {
            try
            {
                monCol20s.MonitorArray.RemoveAt(lb20s.SelectedIndex);
                lb20s.Items.RemoveAt(lb20s.SelectedIndex);
                lb20s.SelectedIndex = 0;
                MessageBox.Show("Monitor Deleted", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Error in removing monitor", "Melbourne Weather Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Out.WriteLine("Error in removing Monitor: " + e3);
            }
        }

        private void gaugeTemp_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void lab_Load(object sender, EventArgs e)
        {

        }
    }
}
