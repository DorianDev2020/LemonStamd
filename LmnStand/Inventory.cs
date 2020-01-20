using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
<<<<<<< HEAD
    public class Inventory
    {

=======

    public class Inventory
    {
>>>>>>> 8a13276c7e59f99c3cccf0a77878666a2a2f4874
        public List<Lemon> lemon;
        public List<SugarCube> sugar;
        public List<IceCube> ice;
        public List<Pitcher> pitcher;
        public int lemonadeCup;
        public Inventory()
        {
            lemon = new List<Lemon>();
            sugar = new List<SugarCube>();
            ice = new List<IceCube>();
            pitcher = new List<Pitcher>();
            lemonadeCup = 0;
        }
        public void ResetInventory()
        {
            lemon.Clear();
            sugar.Clear();
            ice.Clear();
            pitcher.Clear();
        }
<<<<<<< HEAD
        public void DisplayInventory()
        {
            Console.WriteLine($" You Have {lemon.Count} Lemons");
            Console.WriteLine($" You Have {sugar.Count} Sugar Cubes");
            Console.WriteLine($" You Have {ice.Count} Ice Cubes");
            Console.WriteLine($" You Have {pitcher.Count} Pitchers");
            GetPitcherToFiveCup();
            Console.WriteLine($" You Have {lemonadeCup} Cups of Lemonade");
            Console.WriteLine("\n Please Press Enter To Continue");
            Console.ReadLine();
        }
        public void DisplayPitcherMade()
        {
            Console.WriteLine($"\n You Have {pitcher.Count} Pitchers");
            Console.ReadLine();
        }
        public void AddLemon()
        {
            lemon.Add(new Lemon());
        }
        public void AddSugar()
        {
            sugar.Add(new SugarCube());
        }
        public void AddIce()
        {
            ice.Add(new IceCube());
        }
        public void AddPitcher()
        {
            pitcher.Add(new Pitcher());
        }

        public void GetPitcherToFiveCup() 
        {
            lemonadeCup = pitcher.Count * 5;
        
        }




    }
       

}





  

   
















=======

        public void DisplayInventory()
        {
            Console.WriteLine($" You Have {lemon.Count} Lemon");
            Console.WriteLine($" You Have {sugar.Count} Sugar Cube");
            Console.WriteLine($" You Have {ice.Count} Ice Cube");
            Console.WriteLine($" You Have {pitcher.Count} Pitcher");
            GetPitcherToFiveCup();
            Console.WriteLine($" You Have {lemonadeCup} Cups Fill With Lemonade");
            Console.WriteLine("\n Press Enter To Continue");
            Console.ReadLine();
        }
        public void DisplayPitcherMade()
        {
            Console.WriteLine($"\n You Have {pitcher.Count} Pitcher");
            Console.ReadLine();
        }
        public void AddLemon()
        {
            lemon.Add(new Lemon());
        }
        public void AddSugar()
        {
            sugar.Add(new SugarCube());
        }
        public void AddIce()
        {
            ice.Add(new IceCube());
        }
        public void AddPitcher()
        {
            pitcher.Add(new Pitcher());
        }
        public void MakePitcher(Recipe recipe)
        {
            while (lemon.Count >= recipe.recipeLemon && sugar.Count >= recipe.recipeSugar && ice.Count >= recipe.recipeIce)
            {
                for (int a = 0; a < recipe.recipeLemon; a++)
                {
                    lemon.RemoveAt(0);
                }
                for (int b = 0; b < recipe.recipeSugar; b++)
                {
                    sugar.RemoveAt(0);
                }
                for (int c = 0; c < recipe.recipeIce; c++)
                {
                    ice.RemoveAt(0);
                }
                AddPitcher();
            }
        }
        public void GetPitcherToFiveCup()
        {
            lemonadeCup = pitcher.Count * 5;
        }
    }
}
>>>>>>> 8a13276c7e59f99c3cccf0a77878666a2a2f4874
