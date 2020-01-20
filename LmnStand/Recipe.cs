using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Recipe
    {
        public int recipeLemon;
        public int recipeSugar;
        public int recipeIce;
        public Recipe()
        {
            recipeLemon = 0;
            recipeSugar = 0;
            recipeIce = 0;
        }
        public void GetRecipe()
        {
            Console.WriteLine($"\n {recipeLemon} Lemon, {recipeSugar} Sugar Cube, and {recipeIce} Ice Cube Will Be Equal To A Pitcher With 1 Pitcher Equaling 5 cups");
        }
<<<<<<< HEAD

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













=======
>>>>>>> 8a13276c7e59f99c3cccf0a77878666a2a2f4874
    }
}
