using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{

    public class Inventory 
    {

            
            public List<Lemon> lemons;
            public List<SugarCube> sugarCubes;
            public List<IceCube> iceCubes;
            public List<Cup> lemonadeCups;
            
        

        public Inventory()
        {
                lemons = new List<Lemon>();
                sugarCubes = new List<SugarCube>();
                iceCubes = new List<IceCube>();
                lemonadeCups = new List<Cup>();
        }
        public void ResetInventory()
        {
            lemons.Clear();
            sugarCubes.Clear();
            iceCubes.Clear();
            lemonadeCups.Clear();
        }

        public void DisplayInventory()
        {
            Console.WriteLine($" You Have {lemons.Count} Lemons");
            Console.WriteLine($" You Have {sugarCubes.Count} Sugar Cubes");
            Console.WriteLine($" You Have {iceCubes.Count} Ice Cubes");
            Console.WriteLine($" You Have {lemonadeCups.Count} Lemonade Cups");
            //GetPitcherToFiveCup();
            Console.WriteLine("\n Please Press Enter To Continue");
            Console.ReadLine();
        }
        //public void DisplayPitcher()
        //{
        //    Console.WriteLine($"\n You Have {pitcher.Count} Pitchers");
        //    Console.ReadLine();
        //}
        public void AddLemon()
        {
            lemons.Add(new Lemon());
        }
        public void AddSugar()
        {
            sugarCubes.Add(new SugarCube());
        }
        public void AddIce()
        {
            iceCubes.Add(new IceCube());
        }
        public void AddCup()
        {
            lemonadeCups.Add(new Cup());
        }

     
    //public void GetPitcherToFiveCup()
    //    {
    //        lemonadeCup = pitcher.Count * 5;

    //    }


        public void MakePitcher(Recipe recipe)      //Consider moving to Player or Recipe class
        {
            while (lemons.Count >= recipe.recipeLemon && sugarCubes.Count >= recipe.recipeSugarCube)
            {
                for (int a = 0; a < recipe.recipeSugarCube; a++)
                {
                    sugarCubes.RemoveAt(0);
                    
                }

                for (int b = 0; b < recipe.recipeIceCube; b++)
                {
                    iceCubes.RemoveAt(0);
                }

                for (int c = 0; c < recipe.recipeLemon; c++)
                {
                    lemons.RemoveAt(0);
                }

               
            }

            
        
        
        
        
        
        
        
        
        }
       



























































    }
    }




  

   
















