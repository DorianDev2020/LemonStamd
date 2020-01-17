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
        public Day()//Member Variables
        {
            customer = new Customer();
            weather = new Weather();
            days = 0;
        }
        public void SetDay() // This Method Allows The User to Choose How Many Days Theyd Like To Play, I also implemented a try catch
            //to account for user error.
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
        public void GetTodayForecast() // This Method Displays the Temperature and Forecast to the user.
        {
            weather.GetTodayTemperature();
            weather.GetForecast();
            Console.WriteLine($"\n Today Forecast Will Be {weather.Forecast} And {weather.TodayTemperature} F");
            Console.ReadLine();
        }
        public void GetRandomForecast() //This Method Generates the Predicted Forecast
        {
            weather.GetTodayTemperature();
            weather.GetForecast();
            Console.WriteLine($"\n Next Day Forecast Will Be {weather.Forecast} And {weather.TodayTemperature}° F");
            Console.WriteLine();
        }

    }
}
