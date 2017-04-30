using System;
using System.Collections.Generic;

namespace WeatherMonitor
{
    class LocationCollection
    {
        //Instance Variables
        private List<LocationFactory> locationArray = new List<LocationFactory>();//Using a list for it's dynamic functionality and memory performance

        //Getter/Setter
        internal List<LocationFactory> LocationArray {
            get => locationArray;
            set => locationArray = value;
        }

        //There is no need to redefine the constructor

        public bool addToCollection(LocationFactory location) //Taking an entire location factory as an argument.
        {
            try//Trying to store the location factory
            {
                locationArray.Add(location);//Add the location factory to the array of locations factories
                return true;
            }catch (Exception e)
            {
                Console.Out.Write(e);//Anny errors outputted
                return false;
            }
        }

        public bool clear()//Essentially clears the array. Not stricly needed, just makes logical sense
        {
            try
            {
                locationArray.Clear();//Clears array
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
