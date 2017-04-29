using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class LocationFactory
    {
        private string locationName;
        private string timeStamp;

        public string LocationName { get => locationName; set => locationName = value; } //Basic getters/setters
        public string TimeStamp { get => timeStamp; set => timeStamp = value; } //Basic getters/setters

        public LocationFactory(String locationName)
        {
            this.locationName = locationName;
            timeStamp = DateTime.Now.ToString("MM/dd/HH:mm:ss");
        }

        public LocationFactory()//alternative empty constructor
        {
            this.locationName = "null";
            timeStamp = DateTime.Now.ToString("MM/dd/HH:mm:ss");
        }
    }
}
