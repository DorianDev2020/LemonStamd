using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Day : Weather
    {
        public Customer customer;
        public Weather weather;
        public int days;
        public Day()
        {
            customer = new Customer();
            weather = new Weather();
            days = 0;
        }
        public void SetDay()
        {
            Console.WriteLine("/n  How Many Days Do You Want To Play?");
            Console.Write("Enter Number Of Days Here");
            try
            {
                days = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(" How Many Days?");
                SetDay();
            }
               
        }
        public void GetTodayForecast()
        {
            weather.GetTodayTemperature();
            weather.GetForecast();
            Console.WriteLine($"\n Today Forecast Will Be {weather.Forecast} And {weather.TodayTemperature} F");
            Console.ReadLine();
        }
        public void GetRandomForecast()
        {
            weather.GetTodayTemperature();
            weather.GetForecast();
            Console.WriteLine($"\n Next Day Forecast Will Be {weather.Forecast} And {weather.TodayTemperature}° F");
            Console.WriteLine();
        }

    }
}
