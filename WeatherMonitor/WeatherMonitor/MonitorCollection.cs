using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    class MonitorCollection
    {
        //Instance Variables
        private List<MonitorFactory> monitorArray = new List<MonitorFactory>();//Using a list for it's dynamic functionality and memory performance

        //Getter/setter
        internal List<MonitorFactory> MonitorArray {
            get => monitorArray;
            set => monitorArray = value;
        }

        public Boolean addToCollection(MonitorFactory mon)//Add an entire monitor factory instance to monitorcollection
        {
            try//Try to add to collection
            {
                monitorArray.Add(mon);//Adding instance to array
                Console.Out.WriteLine("Updating " + MonitorArray[monitorArray.Count - 1].LocationName);
                monitorArray[monitorArray.Count-1].update();//Updating newly added element
                return true;//stewi, if you read this, please just send me a message. I need to explain something.
            }catch(Exception e)
            {
                Console.Out.WriteLine(e);
                return false;
            }
        }

        public Boolean update()//calling the update method for each element in the MonitorCollection
        {
            try {//Trying to update each monitorFactory instance that we have stored
                foreach (MonitorFactory i in monitorArray)
                {
                    Console.Out.WriteLine("Updating " + i.LocationName);
                    i.update();//Yo. 
                }
                return true;
            }catch(Exception e)//If it makes a mess
            {
                Console.Out.WriteLine(e);
                return false;
            }   
        }
    }   
}
