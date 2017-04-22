using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class MonitorFactory
    {
        string locationName;
        string timeStamp;

        public MonitorFactory(String locationName)
        {
            locationName = this.locationName;
            timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
    }
}
