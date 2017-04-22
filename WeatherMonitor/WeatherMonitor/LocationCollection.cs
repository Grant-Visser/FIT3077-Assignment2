using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class LocationCollection
    {
        //private LocationFactory[] locationArray;
        private List<LocationFactory> locationArray = new List<LocationFactory>();//Using a list for it's dynamic functionality and memory performance

        public LocationCollection(string[] input) //input comes from the webservice
        {
            for (int i = 0; i <= input.Length-1 ; i++)
            {
                LocationFactory temp = new LocationFactory(input[i]); //Creating a collection of location factories
                locationArray.Add(temp);
            }
        }

        public Boolean update()
        {
            try
            {
                //web server stuff goes here or should we have it that the only way that the application can see new addresses be that the app restarts.
                return true;
            }catch (Exception e)
            {
                Console.Out.WriteLine(e);
                return false;
            }
            
        }

        public string getAreas()
        {
            string output = null;
            for (int i = 0; i <= locationArray.Count-1; i++)
            {
                output += locationArray[i].LocationName + "\n";
            }
            return output;
        }
    }
}
