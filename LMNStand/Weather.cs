using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMNStand
{
    public class Weather
    {
        public int temperature;
        private List<string> weatherconditions;
        public string predictedforecast;

        public Weather()
        {
            weatherconditions = new List<string>();
            weatherconditions.Add(" Rain");
            weatherconditions.Add(" Cloudy");
            weatherconditions.Add(" Sunny");
            weatherconditions.Add(" Snow");
            weatherconditions.Add(" Overcast");
        }
       
    }
    
}
