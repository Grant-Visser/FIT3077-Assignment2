using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class LocationFactory
    {
        string locationName;
        string timeStamp;

        public LocationFactory(String locationName, String timeStamp)
        {
            locationName = this.locationName;
            timeStamp = this.timeStamp; 
        }
    }
}
