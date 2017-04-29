
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class MonitorFactory : LocationFactory //Need to make sure we actually need this, due to the fact that I don't know how to turn the location factory structure into the MonitorFactory.
    {
        private string updateTimeStamp;
        private string[] temp;
        private string[] rain;
        private bool readTemp;
        private bool readRain;

        public bool ReadTemp { get => readTemp; set => readTemp = value; } //Basic getters/setters
        public bool ReadRain { get => ReadRain; set => ReadRain = value; } //Basic getters/setters
        public string UpdateTimeStamp { get => updateTimeStamp; } //Basic getters/setters
        public string[] Temp { get => temp; set => temp = value; }
        public string[] Rain { get => rain; set => rain = value; }

        public MonitorFactory(LocationFactory location, bool getRain, bool getTemp): base(location.LocationName) //This is super weird. Need to find a better way. 
            //Calling the base class's named constructor. Technically duplicating the base class. Revise this.
        {
            updateTimeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            readRain = getRain;
            readTemp = getTemp;

        }

        public Boolean update()
        {
            if (!readRain && !readTemp)
            {
                Console.Out.WriteLine("Nothing to update for: " + base.LocationName);
                return false;
            }
            else {
                try
                {
                    //Web service Goes here
                    Console.Out.WriteLine("Updating");
                    WebInterface wi = new WebInterface();
                    if (readTemp)
                    {
                        temp = wi.getTemperature(base.LocationName);
                        Console.Out.WriteLine("Temperature updated: " + temp[1]);
                        updateTimeStamp = temp[0];
                    }
                    if (readRain)
                    {
                        rain = wi.getRainfall(base.LocationName);
                        Console.Out.WriteLine("Rainfall updated: " + rain[1]);
                        updateTimeStamp = rain[0];
                    }
                    
                    return true;
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine(e);
                    return false;
                }
            }
            
        }
    }
}
