using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class MonitorCollection
    {
        //private MonitorFactory[] monitorArray;//Copy past is bad juju
        private List<MonitorFactory> monitorArray = new List<MonitorFactory>();//Using a list for it's dynamic functionality and memory performance

        internal List<MonitorFactory> MonitorArray { get => monitorArray; set => monitorArray = value; }

        public Boolean addToCollection(MonitorFactory mon) //TODO: we need to add two more arguments to be filled by the form when creating this monitor
        {
            try
            {
                monitorArray.Add(mon);//Fix this with the new bool values in constructor.
                monitorArray[monitorArray.Count-1].update();//Updating newly added element
                return true;
            }catch(Exception e)
            {
                Console.Out.WriteLine(e);
                return false;
            }
        }

        public Boolean update()//Complete
        {
            try {
                foreach (MonitorFactory i in monitorArray)
                {
                    i.update();
                }
                return true;
            }catch(Exception e)
            {
                Console.Out.WriteLine(e);
                return false;
            }   
        }
    }   
}
