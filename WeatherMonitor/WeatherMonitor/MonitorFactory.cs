using System;

namespace WeatherMonitor
{
    public class MonitorFactory : LocationFactory //Extends the LocationFactory class, which means we need to call it's constructor somewhere.
    {
        //Instance Variables
        private string updateTimeStamp;
        private string[] temp;
        private string[] rain;
        private bool readTemp;
        private bool readRain;
        private int apiType;

        //Basic getters/setters
        public bool ReadTemp {
            get => readTemp;
            set => readTemp = value;
        }

        public bool ReadRain {
            get => readRain;
            set => readRain = value;
        }

        public string UpdateTimeStamp {
            get => updateTimeStamp;
        }

        public string[] Temp {
            get => temp;
            set => temp = value;
        }

        public string[] Rain {
            get => rain;
            set => rain = value;
        }

        public int ApiType{
            get => apiType;
            set => apiType = value;
        }

        //Custom constructor that also calls the base classes constructor
        public MonitorFactory(LocationFactory location, bool getRain, bool getTemp, int apiType): base(location.LocationName)//Calling the base class's named constructor.
        {
            updateTimeStamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");//Updating the timestamp
            readRain = getRain;//setting instance variables
            readTemp = getTemp;
            this.ApiType = apiType;

        }

        public Boolean update() //Update function called by collection class and when created
        {
            if (!readRain && !readTemp) //This path does need to be considered!
            {
                Console.Out.WriteLine("Nothing to update for: " + base.LocationName);
                temp = new string[] { "Not Requested", "Not Requested", "Not Requested"};//Fill the string with nothing if you dont need it
                rain = new string[] { "Not Requested", "Not Requested", "Not Requested"};//Fill the string with nothing if you dont need it
                return false;
            }
            else {
                switch (apiType)
                {
                    case 1: //Old 5Min API
                        try//We're trying to update the things that need updating
                        {
                            Console.Out.WriteLine("Updating");
                            WebInterface wi = new WebInterface();//Creating a new instance of my WebInterface class to fetch data.
                            if (readTemp)//If we need to get the temp, do the code below
                            {
                                temp = wi.getTemperature(base.LocationName);//fetching temperature
                                if (temp[1] == "")//Handling server side errors.
                                {
                                    temp[1] = "Server Error";
                                }
                                Console.Out.WriteLine("Temperature updated: " + temp[1]);
                                updateTimeStamp = temp[0];//Update timestamp that is included in the temperature fetch
                            }
                            else
                            {
                                temp = new string[] { "Not Requested", "Not Requested" };//Fill the string with nothing if you dont need it
                            }
                            if (readRain)
                            {
                                rain = wi.getRainfall(base.LocationName);//fetching rain
                                if (rain[1] == "")//Handling server side errors.
                                {
                                    rain[1] = "Server Error";
                                }
                                Console.Out.WriteLine("Rainfall updated: " + rain[1]);
                                updateTimeStamp = rain[0];//Update timestamp that is included in the temperature fetch
                            }
                            else
                            {
                                rain = new string[] { "Not Requested", "Not Requested" };//Fill the string with nothing if you dont need it
                            }
                            return true;
                        }
                        catch (Exception e)//If it makes a mess, then do this
                        {
                            Console.Out.WriteLine(e);
                            return false;
                        }
                    case 2: //New 20Sec API
                        try//We're trying to update the things that need updating
                        {
                            Console.Out.WriteLine("Updating");
                            TimeLapse tl = new TimeLapse();//Creating a new instance of my WebInterface class to fetch data.

                            if (true)//If we need to get the weather, as they are both included in the one API Call
                            {
                                temp = tl.getWeather(base.LocationName);//fetching temperature
                                temp[1] = Convert.ToString(Math.Round(Convert.ToDouble(temp[1]) - 273.15,2));//From Kelvin to C
                                if (temp[1] == "")//Handling server side errors.
                                {
                                    temp[1] = "Server Error";
                                }
                                Console.Out.WriteLine("Temperature updated: " + temp[1]);
                                updateTimeStamp = temp[0];//Update timestamp that is included in the temperature fetch
                            }
                            else
                            {
                                temp = new string[] { "Not Requested", "Not Requested", "Not Requested"};//Fill the string with nothing if you dont need it
                            }
                            rain = temp;//Same data anyway.
                            return true;
                        }
                        catch (Exception e)//If it makes a mess, then do this
                        {
                            Console.Out.WriteLine(e);
                            return false;
                        }
                    default: //You've implemented your new API Wrong.
                        return false;
                }
            }
            
        }
    }
}
