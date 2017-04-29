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

        internal List<LocationFactory> LocationArray { get => locationArray; set => locationArray = value; }

        public bool addToCollection(LocationFactory location)
        {
            try
            {
                locationArray.Add(location);
                return true;
            }catch (Exception e)
            {
                Console.Out.Write(e);
                return false;
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

        public bool clear()
        {
            try
            {
                locationArray.Clear();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
