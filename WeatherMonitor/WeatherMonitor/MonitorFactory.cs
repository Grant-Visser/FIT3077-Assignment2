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
        private double temp;
        private double rain;
        private bool readTemp;
        private bool readRain;

        public double Temp { get => temp; set => temp = value; } //Basic getters/setters
        public double Rain { get => rain; set => rain = value; } //Basic getters/setters
        public bool ReadTemp { get => readTemp; set => readTemp = value; }
        public bool ReadRain { get => ReadRain; set => ReadRain = value; }
        public string UpdateTimeStamp { get => updateTimeStamp; } //Basic getters/setters

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
