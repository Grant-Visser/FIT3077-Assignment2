//Created by Grant Visser - 25476807 - grvis1@student.monash.edu - For educational use only! Distibuted and explained to students who asked for assistance.
//Class based on concept presented by Patrick Shaw on Moodle Forums - Please see his thread for instructions to add a service reference to your project: http://moodle.vle.monash.edu/mod/forum/discuss.php?d=1031263#p2863261
//V1.1
//Step 1. Right click on connected services -> add service reference -> paste http://viper.infotech.monash.edu.au:8180/axis2/services/MelbourneWeatherTimeLapse?wsdl -> go. 
//Once the service is identified, give it a name. I've used MelbourneWeatherTimelapse. 

using WeatherMonitor.MelbourneWeatherTimelapse; //Step 2. Change this to using <YourAppNamespace>.<YourConnectedServiceName>;

namespace WeatherMonitor //Step 3. Change this to your app namespace 
{
    class TimeLapse
    {
        private MelbourneWeatherTimeLapsePortTypeClient timeLapse = new MelbourneWeatherTimelapse.MelbourneWeatherTimeLapsePortTypeClient("MelbourneWeatherTimeLapseHttpSoap12Endpoint");//Creating a new client connection using the webservice added to VS.
        public string[] getLocations()//returns a string array of all locations
        {
            string[] locations = timeLapse.getLocations();//Saving locations to the local string array to be returned
            return locations;
        }

        public string[] getWeather(string location)//Returns a string array of {timestamp,rainfall} in mm for a given location
        {
            string[] rainfallData = timeLapse.getWeather(location); //Saving Rainfall data to the local string array to be returned
            if (rainfallData == null)
            {
                rainfallData = new string[]{"0", "0", "0"};
            }
            return rainfallData;
        }
    }
}
