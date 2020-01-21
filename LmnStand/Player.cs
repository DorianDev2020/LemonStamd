using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{

       

    public class Player 

    {
        public Recipe recipe;
        public Inventory inventory;
        public string playerName;
        public double Bank;
        public double LemonadePrice;
        public double CashEarn;
        public double Cashspend;
        public Random CashToBank;
        public Pitcher pitcher;
        public Wallet wallet;
        public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();
            Bank = 15.00;
            LemonadePrice = .15;
            CashEarn = 0;
            Cashspend = 0;
            CashToBank = new Random();
        }
        public void AddCashEarn()
        {
            Bank = CashEarn + Bank;
        }
        public void MakeRecipeDisplay()
        {
            Console.Clear();
            inventory.DisplayInventory();
            recipe.GetRecipe();
            Console.WriteLine("\n It's Time To Make Your Lemonade Recipe!");
            Console.WriteLine(" [1] Lemon  [2] Sugar Cube  [3] Ice Cube  [4] Exit");
            Console.Write(" Enter Here: ");
            string ChooseLetter = Console.ReadLine();
            switch (ChooseLetter)
            {
                case "1":
                    InputLemon();
                    break;
                case "2":
                    InputSugar();
                    break;
                case "3":
                    InputIce();
                    break;
                case "4":
                    break;
                default:
                    MakeRecipeDisplay();
                    break;
            }

            //inventory.MakePitcher();          //consider move
        }
        public void InputLemon()
        {
            try
            {
                Console.WriteLine("\n How Many Lemons Would You Like To Use?");
                Console.Write(" Enter Number Here: ");
                recipe.recipeLemon = int.Parse(Console.ReadLine());
                MakeRecipeDisplay();
            }
            catch (Exception)
            {
                Console.WriteLine(" Please Enter A Number");
                InputLemon();
            }
        }
        public void InputSugar()
        {
            try
            {
                Console.WriteLine("\n How Many Sugar Cubes Would You Like To Use?");
                Console.Write(" Enter Number Here: ");
                recipe.recipeSugarCube = int.Parse(Console.ReadLine());
                MakeRecipeDisplay();
            }
            catch (Exception)
            {
                Console.WriteLine(" Please Enter A Number");
                InputSugar();
            }
        }
        public void InputIce()
        {
            try
            {
                Console.WriteLine("\n How Many Ice Cubes Would You Like To Use?");
                Console.Write(" Enter Number Here: ");
                recipe.recipeIceCube = int.Parse(Console.ReadLine());
                MakeRecipeDisplay();
            }
            catch (Exception)
            {
                Console.WriteLine(" Please Enter A Number");
                InputIce();
            }
        }
        public void DisplayCashFlow()
        {
            AddCashEarn();
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine($" Money: ${Bank.ToString("0.00")} ");
            Console.WriteLine($" Spent Today: ${Cashspend.ToString("0.00")} ");
            Console.WriteLine($" Cash Earn Today: ${CashEarn.ToString("0.00")}");
            Console.WriteLine("\n Press Enter To Exit");
            Console.ReadLine();
        }
        public void GetChange(UserInterface gameInfo)
        {
            gameInfo.ToClearScreen();
            gameInfo.DisplayGameTitle();
            Console.WriteLine($"\n Your Current Lemonade Price Is ${LemonadePrice.ToString("0.00")}");
            //inventory.MakePitcher();

            gameInfo.ToContinue();
            recipe.GetRecipe();
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine("\n Will You Like To Change Your Price Or Recipe");
            Console.WriteLine(" [1]-Change Lemonade Price  [2]-Change Recipe To Make Lemonade Pitcher  [3]-Exit");
            Console.Write(" Enter Here: ");
            string ChangeChoice = Console.ReadLine();
            switch (ChangeChoice)
            {
                case "1":
                    ChangeLemonadePrice();
                    GetChange(gameInfo);
                    break;
                case "2":
                    MakeRecipeDisplay();
                    GetChange(gameInfo);
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("\n Invalid Option");
                    gameInfo.ToContinue();
                    GetChange(gameInfo);
                    break;
            }
        }
        public void GetBankTotal()
        {
            Console.WriteLine($"\n {playerName}, Have ${Bank}");
        }
        
        public void GetLemonadePrice()
        {
            Console.WriteLine($"\n Your Current Lemonade Price Is ${LemonadePrice.ToString("0.00")}");
        }
        public void ChangeLemonadePrice()
        {
            Console.WriteLine($"\n Your Current Lemonade Price Is ${LemonadePrice.ToString("0.00")}");
            Console.WriteLine("\n Will You Like To Change The Lemonade Price.");
            Console.Write(" [Y] Yes Or [N] No: ");
            string PriceChange = Console.ReadLine().ToLower();
            switch (PriceChange)
            {
                case "y":
                    do
                    {
                        ChangePrice();
                    } while (LemonadePrice > 2.00);
                    break;
                case "n":
                    Console.WriteLine(" Okay Your Price Will Stay The Same");
                    Console.WriteLine("\n Press Enter To Exit");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine(" That Was Not A Option");
                    ChangeLemonadePrice();
                    break;
            }
        }
        public void ChangePrice()
        {
            Console.WriteLine(" Enter The Price You Want To Set To, Your Price Max Is $2.00.");
            Console.Write(" Enter New Price Here: ");
            try
            {
                LemonadePrice = double.Parse(Console.ReadLine());
                if (LemonadePrice >= 0 && LemonadePrice <= 2.00)
                {
                    Console.WriteLine("\n Press Enter To Exit");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Price Max Set Is $2.00");
                }
            }
            catch (Exception)
            {
                Console.WriteLine(" Please Enter A Number");
                ChangePrice();
            }
        }
        public void GetPlayerName()
        {
            Console.Write("\n Please Enter Your Name: ");
            playerName = Console.ReadLine();
        }
    }

}
