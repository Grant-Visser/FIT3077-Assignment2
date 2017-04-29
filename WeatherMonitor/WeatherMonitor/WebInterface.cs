//Created by Grant Visser - 25476807 - grvis1@student.monash.edu

using WeatherMonitor.MelbourneWeatherService;

namespace WeatherMonitor
{
    class WebInterface
    {
        //Instance Variables
        private MelbourneWeather2PortTypeClient webservice = new MelbourneWeatherService.MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");//Creating a new client connection using the webservice added to VS.

        public string[] getLocations()//returns a string array of all locations
        {
            string[] locations = webservice.getLocations();//Saving locations to the local string array to be returned
            return locations;
        }

        public string[] getRainfall(string location)//Returns a string array of {timestamp,rainfall} in mm for a given location
        {
            string[] rainfallData = webservice.getRainfall(location); //Saving Rainfall data to the local string array to be returned
            return rainfallData;
        }

        public string[] getTemperature(string location)//Returns a string array of {timestamp,temp} in mm for a given location
        {
            string[] temperatureData = webservice.getTemperature(location);//Saving temp data to the local string array to be returned
            return temperatureData;
        }
    }
}
