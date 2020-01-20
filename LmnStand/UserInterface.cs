using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class UserInterface
    {
        public void GetWelcome()
        {
            Console.WriteLine("\n Welcome To The Lemonade Stand Game");
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("\n Introduction ");
            Console.WriteLine(" ____________");
            Console.WriteLine("\n   You will have 7 day to make as much money as you can. By the end of the week you will see how much profit you made. \n You’ll also have complete control over your business, price, inventory, and \n purchasing supplies. Buy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("\n Dont Forget To keep An Eye On The Forecast, This Determines How Many Potential Customers You Might Have.");
            Console.WriteLine("\n --------------------------------------------------------------------------------------------------------------------");
        }
        public void GetRule()
        {
            Console.WriteLine(" Rules");
            Console.WriteLine(" 1) You will choose a number from 1 to 3 to see how much cash you get to start with.");
            Console.WriteLine(" 2) Choose how many day You Want to Play");
            Console.WriteLine(" 3) Buy your ingredients");
            Console.WriteLine(" 4) Set your recipe");
            Console.WriteLine(" 5) Set your Price");
            Console.WriteLine(" 6) Start The Day");
            Console.WriteLine("\n --------------------------------------------------------------------------------------------------------------------");
        }
        public void DisplayGameTitle()
        {
            Console.WriteLine("\n ------------------");
            Console.WriteLine(" | Lemonade Stand |");
            Console.WriteLine(" ------------------");
        }
        public void DisplayFastRule()
        {
            Console.WriteLine("\n Before You Start The Day Please Purchase Your Ingredients And Set Your Price And Recipe");
        }
        public void DisplayQuitGame()
        {
            Console.Write("\n Are You Sure You Want To Quit \n   Y = Yes | N = NO: ");
            string playChoice = Console.ReadLine().ToLower();
            switch (playChoice)
            {
                case "y":
                    Environment.Exit(0);
                    break;
                case "n":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine(" That Was Not A Valid Option");
                    DisplayQuitGame();
                    break;
            }
        }
        public void ToContinue()
        {
            Console.WriteLine("\n Press Enter To Continue");
            Console.ReadLine();
        }
        public void ToClearScreen()
        {
            Console.Clear();
        }
    }
}
