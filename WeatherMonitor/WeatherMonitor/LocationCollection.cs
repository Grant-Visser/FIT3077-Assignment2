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
            for (int i = 0; i <= input.Length; i++)
            {
                LocationFactory temp = new LocationFactory(input[i]);
            }
        }

        public Boolean update()
        {
            return false;
        }
    }
}
