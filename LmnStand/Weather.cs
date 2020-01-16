using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    class Weather
    {
        Random random;

        public int Temperature;
        public int TodayTemperature;
        public string WeatherTypes;
        public string Forecast;
        public Weather()
        {
            random = new Random();
            TodayTemperature = 0;
            Forecast = "";
        }
        public void GetTodayTemperature()
        {

            Temperature = random.Next(50, 90);
            TodayTemperature = Temperature;
        }
        public void GetForecast()
        {
            List<string> TypesOfWeather = new List<string>();
            TypesOfWeather.Add(" Sunny");
            TypesOfWeather.Add(" Rainy");
            TypesOfWeather.Add(" Cloudy");
            WeatherTypes = TypesOfWeather[random.Next(0, 2)];
            Forecast = WeatherTypes;
        }
    }
}
