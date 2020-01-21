using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{

    public class Inventory 
    {

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
                pitcher = new List<Ingredient>();
                lemonadeCup = 0;
            }
            public void ResetInventory()
            {
                lemon.Clear();
                sugar.Clear();
                ice.Clear();
                pitcher.Clear();
            }

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
            public void MakePitcher()
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


        public void AddingToPitcher(Recipe recipe)
        {
            while (lemon.Count >= recipe.recipeLemon && sugar.Count >= recipe.recipeSugarCube)
            {
                for (int a = 0; a < recipe.recipeSugarCube; a++)
                {
                    SugarCube.RemoveAt(0);
                    
                }

                for (int b = 0; b < recipe.recipeIceCube; b++)
                {
                    IceCube.RemoveAt(0);
                }

                for (int c = 0; c < recipe.recipeLemon; c++)
                {
                    Lemon.RemoveAt(0);
                }

                Add.Pitcher();

            }
        }




























































    }
    }




  

   
















