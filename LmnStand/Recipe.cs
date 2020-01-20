using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Recipe
    {

        public int amountOfLemons;
        public int  amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe() 
        {
        
        
        
        
        }

        public void MakePitcher(Recipe recipe) 
        {
            while (lemon.Count >= recipe.recipeLemon && sugar.Count >= recipe.recipeIce) 
            {
                for (int a = 0; a < lemon; a++)
                {

                    lemon.RemoveAt(0);

                }

                for (int b = 0; b < sugarCube; b++)
                {
                    sugarCube.RemoveAt(0);
                }

                for (int c = 0; c < icecube; c++)
                {
                    IceCube.RemoveAt(0);
                }


            }
        
        
        
        }













    }
}
