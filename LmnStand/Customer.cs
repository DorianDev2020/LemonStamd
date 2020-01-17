using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Customer : Inventory //Member Variables
    {
        public int Buyer;
        public double MoneyMadeToday;
        public Random BuyChances;
        public Customer()
        {
            Buyer = 0;
            MoneyMadeToday = 0;
            BuyChances = new Random();
        }
        public void CustomerBuyer(Weather weather, Player player)
        {
            if ((weather.Temperature > 50 && weather.Temperature <= 95) || (weather.WeatherTypes == "Rainy") || (player.LemonadePrice <= 0.25))
            {
                if (0 < player.Inventory.lemonadeCup)
                {
                    Buyer = BuyPicker.Next(1, player.inventory.lemonadeCup);
                    Console.WriteLine($" {Buyer} People Bought Your Lemonade");
                    Console.ReadLine();
                    MoneyMadeToday = Buyer * player.LemonadePrice;
                    player.CashEarn = MoneyMadeToday;
                }
                else if (0 == player.inventory.lemonadeCup)
                {
                    Console.WriteLine(" Sorry You Got No Customer");
                }
            }
            else if ((weather.Temperature > 50 && weather.Temperature <= 65) || (weather.WeatherTypes == "Sunny" && weather.WeatherTypes == "Partly Cloudy") || (player.LemonadePrice <= .75))
            {
                if (0 < player.inventory.lemonadeCup)
                {
                    Buyer = BuyPicker.Next(1, player.inventory.lemonadeCup);
                    Console.WriteLine($" {Buyer} People Bought Your Lemonade");
                    Console.ReadLine();
                    MoneyMadeToday = Buyer * player.LemonadePrice;
                    player.CashEarn = MoneyMadeToday;
                }
                else if (0 == player.inventory.lemonadeCup)
                {
                    Console.WriteLine(" Sorry You Got No Customer");
                }
            }
            else if ((weather.Temperature > 65 && weather.Temperature <= 75) || (weather.WeatherTypes == "Sunny" && weather.WeatherTypes == "Partly Cloudy") || (player.LemonadePrice <= 1.50))
            {
                if (0 < player.inventory.lemonadeCup)
                {
                    Buyer = BuyPicker.Next(25, player.inventory.lemonadeCup);
                    Console.WriteLine($" {Buyer} People Bought Your Lemonade");
                    Console.ReadLine();
                    MoneyMadeToday = Buyer * player.LemonadePrice;
                    player.CashEarn = MoneyMadeToday;
                }
                else if (0 == player.inventory.lemonadeCup)
                {
                    Console.WriteLine(" Sorry You Got No Customer");
                }
            }
            else if ((weather.Temperature > 75 && weather.Temperature <= 85) || (weather.WeatherTypes == "Sunny" && weather.WeatherTypes == "Partly Cloudy") || (player.LemonadePrice <= 1.00))
            {
                if (0 < player.inventory.lemonadeCup)
                {
                    Buyer = BuyPicker.Next(25, player.inventory.lemonadeCup);
                    Console.WriteLine($" {Buyer} People Tried Your Lemonade");
                    Console.ReadLine();
                    MoneyMadeToday = Buyer * player.LemonadePrice;
                    player.CashEarn = MoneyMadeToday;
                }
                else if (0 == player.inventory.lemonadeCup)
                {
                    Console.WriteLine(" Sorry You Got No Customer");
                }
            }
            else if ((weather.Temperature > 85 && weather.Temperature <= 90) || (weather.WeatherTypes == "Sunny" && weather.WeatherTypes == "Partly Cloudy") || (player.LemonadePrice <= .85))
            {
                if (0 < player.inventory.lemonadeCup)
                {
                    Buyer = BuyPicker.Next(1, player.inventory.lemonadeCup);
                    Console.WriteLine($" {Buyer} People Bought Your Lemonade");
                    Console.ReadLine();
                    MoneyMadeToday = Buyer * player.LemonadePrice;
                    player.CashEarn = MoneyMadeToday;
                }
                else if (0 == player.inventory.lemonadeCup)
                {
                    Console.WriteLine(" Sorry You Got No Customer");
                }
            }
        }


    }
}
