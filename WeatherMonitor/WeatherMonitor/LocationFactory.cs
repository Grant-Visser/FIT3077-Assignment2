using System;

namespace WeatherMonitor
{
    class LocationFactory
    {
        //Instance Variables
        private string locationName;
        private string timeStamp;

        //Getters/Setters
        public string LocationName {
            get => locationName;
            set => locationName = value;
        }
        public string TimeStamp {
            get => timeStamp;
            set => timeStamp = value;
        }

        public LocationFactory(String locationName)//Custom constructor
        {
            this.locationName = locationName;//Stores the name of the class locally
            timeStamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");//Updates the timestamp
        }

        public LocationFactory()//Standard constructor initial values 
        {
            this.locationName = "null";
            timeStamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
