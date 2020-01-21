using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    class Game
    {
        public Player player;
        public Store store;
        public UserInterface gameInfo;
        public Day day;

        public Game()
        {
            player = new Player();
            store = new Store();
            gameInfo = new UserInterface();
            day = new Day();
        }
        public void StartGame()
        {
            gameInfo.GetWelcome();
            gameInfo.GetRule();
            player.GetPlayerName();
            gameInfo.ToContinue();
            gameInfo.ToClearScreen();
            gameInfo.DisplayGameTitle();
            player.GetBankTotal();
            gameInfo.ToContinue();
            gameInfo.ToClearScreen();
            gameInfo.DisplayGameTitle();
            day.SetDay();
            gameInfo.ToContinue();
            gameInfo.ToClearScreen();
            // loop
            for (int i = 0; i < day.days; i++)
            {
                player.inventory.ResetInventory();
                player.recipe = new Recipe();
                player.LemonadePrice = .15;
                DisplayMenu();
            }
            RestartGame();

        }
        private void RestartGame()
        {
            gameInfo.ToClearScreen();
            gameInfo.DisplayGameTitle();
            Console.WriteLine("\n Will You Like To Replay The Game");
            Console.WriteLine(" [Y]-Yes  ||  [N]");
            Console.Write(" Enter Input Here: ");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "y":
                    StartGame();
                    break;
                case "n":
                    Environment.Exit(0);
                    break;
                default:
                    RestartGame();
                    break;
            }
        }
        private void DisplayMenu()
        {
            gameInfo.ToClearScreen();
            gameInfo.DisplayGameTitle();
            gameInfo.DisplayFastRule();
            Console.WriteLine($"\n Hi {player.playerName} Will You Like To:");
            Console.WriteLine("\n 1 = Start Day, 2 = Store, 3 = Change Lemonade Price/Recipe, \n 4 = See Inventory, 5 = Cash, 6 = Quit");
            Console.Write(" Enter Number Here: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // start the game day
                    gameInfo.ToClearScreen();
                    gameInfo.DisplayGameTitle();
                    day.GetTodayForecast();
                    Console.WriteLine(" You'll Get One Last Time To Change Your Recipe And Price");
                    player.GetChange(gameInfo);
                    gameInfo.ToClearScreen();
                    gameInfo.DisplayGameTitle();
                    player.DisplayCashFlow();
                    Console.WriteLine(" For Nex Day");
                    Console.ReadLine();
                    gameInfo.ToContinue();
                    break;
                case "2":
                    // method to go shopping at the store
                    store.GoShopping(player, gameInfo);
                    gameInfo.ToClearScreen();
                    DisplayMenu();
                    break;
                case "3":
                    // method to change price and recipe
                    player.GetChange(gameInfo);
                    gameInfo.ToClearScreen();
                    DisplayMenu();
                    break;
                case "4":
                    // method to see inventory
                    player.inventory.DisplayInventory();
                    gameInfo.ToClearScreen();
                    DisplayMenu();
                    break;
                case "5":
                    // method to see cash flow
                    player.DisplayCashFlow();
                    gameInfo.ToClearScreen();
                    DisplayMenu();
                    break;
                case "6":
                    //method to quit game
                    gameInfo.DisplayQuitGame();
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine(" Invalid Answer");
                    gameInfo.ToContinue();
                    DisplayMenu();
                    break;
            }
        }


    }
}
