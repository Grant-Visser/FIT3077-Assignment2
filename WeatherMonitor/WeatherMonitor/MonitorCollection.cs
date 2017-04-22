using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class MonitorCollection
    {
        private MonitorFactory[] locationArray;

        public MonitorCollection(string[] input)
        {
            for (int i = 0; i <= input.Length; i++)
            {
                MonitorFactory temp = new MonitorFactory();
            }
        }

    }

   
}
