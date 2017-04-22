using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class MonitorFactory : LocationFactory
    {
        private string updateTimeStamp;
        private Double temp;
        private Double rain;

        public MonitorFactory(Double temp, Double rain)
        {
            this.temp = temp;//Need to add guards for this
            this.rain = rain;//Need to add guards for this
            updateTimeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }

    }
}
