using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Weather
    {

        public int temperature;
        private List<string> weatherconditions;
        public string predictedforecast;

        public Weather()
        {
            weatherconditions = new List<string>();
            weatherconditions.Add("Rain");
            weatherconditions.Add("Cloudy");
            weatherconditions.Add("Windy");
            weatherconditions.Add("Overcast");
            weatherconditions.Add("Sunny");
        }
       

    }
    
}
