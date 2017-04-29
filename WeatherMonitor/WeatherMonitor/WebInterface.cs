//Created by Grant Visser - 25476807 - grvis1@student.monash.edu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitor.MelbourneWeatherService;

namespace WeatherMonitor
{
    class WebInterface
    {
        private MelbourneWeather2PortTypeClient client = new MelbourneWeatherService.MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");
        public string[] getLocations()
        {
            getLocationsRequest locationsRequest = new getLocationsRequest();
            string[] locations = client.getLocations();
            return locations;
        }

        public string[] getRainfall(string location)
        {
            string[] rainfallData = client.getRainfall(location);
            return rainfallData;
        }

        public string[] getTemperature(string location)
        {
            string[] temperatureData = client.getTemperature(location);
            return temperatureData;
        }
    }
}
