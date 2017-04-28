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
using WeatherMonitor.MelbourneWeatherService;

namespace WeatherMonitor
{
    public partial class lab : Form
    {
        string[] test = { "Moscow", "China", "Cambodia", "Khazakstan" };//Just a temporary list. web service goes here
        MonitorCollection monCol = new MonitorCollection();
        public lab()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            monCol.update();//Updating all elements in Monitor Collection
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            LocationCollection testCol = new LocationCollection(test);//Creating a new Location collection with objects names provided by the temp list
            Console.Out.WriteLine(testCol.getAreas());//Outputting a formatted string to console
            for (int i = 0; i < test.Length; i++)
            {
                monCol.addToCollection(new LocationFactory(test[i]));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Out.WriteLine(lbMonitors.SelectedIndex);
            Console.Out.WriteLine(lbMonitors.SelectedItem);
            Console.Out.WriteLine(lbMonitors.SelectedValue);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Delete This once Trouble shooted
        private const int TIMESTAMP_INDEX = 0;
        private const int RAINFALL_INDEX = 1;
        private const int TEMPERATURE_INDEX = 1;
        private void btnTest_Click(object sender, EventArgs e)
        {
            MelbourneWeather2PortTypeClient client = new MelbourneWeatherService.MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");
            getLocationsRequest locationsRequest = new getLocationsRequest();
            string[] locations = client.getLocations();
            foreach (string location in locations)
            {
                getRainfallRequest rainfallRequest = new getRainfallRequest();
                string[] rainfallData = client.getRainfall(location);
                getTemperatureRequest temperatureRequest = new getTemperatureRequest();
                string[] temperatureData = client.getTemperature(location);
                Debug.WriteLine(
                                    "{0} @ {1}\n\t" +
                                    "Temperature:\t{2}\n\t" +
                                    "Rainfall:\t{3}\n\n",
                                    location,
                                    rainfallData[TIMESTAMP_INDEX],
                                    rainfallData[RAINFALL_INDEX],
                                    temperatureData[TEMPERATURE_INDEX]
                                    );
            }
        }
    }
}
