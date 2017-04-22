using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class LocationCollection
    {
        private LocationFactory[] locationArray;

        public LocationCollection(string[] input)
        {
            locationArray = new LocationFactory[input.Length];
            for (int i = 0; i <= input.Length-1 ; i++)
            {
                LocationFactory temp = new LocationFactory(input[i]);
                locationArray[i] = temp;
            }
        }

        public Boolean update()
        {
            return false;
        }

        public string getAreas()
        {
            string output = null;
            for (int i = 0; i <= locationArray.Length-1; i++)
            {
                output += locationArray[i].getName() + "\n";
            }
            return output;
        }
    }
}
