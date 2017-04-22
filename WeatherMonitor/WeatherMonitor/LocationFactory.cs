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

        public LocationFactory(String locationName)
        {
            locationName = this.locationName;
            timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
    }
}
