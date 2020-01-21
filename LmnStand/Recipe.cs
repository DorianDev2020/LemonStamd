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
        public int recipeSugarCube;
        public int recipeIceCube;

        public Recipe()
        {
            recipeLemon = 0;
            recipeSugarCube = 0;
            recipeIceCube = 0;
            
        }

       

            public void GetRecipe()
            {
                Console.WriteLine($"\n {recipeLemon} Lemon, {recipeSugarCube} Sugar Cube, and {recipeIceCube} Ice Cube Will Be Equal To A Pitcher With 1 Pitcher Equaling 5 cups");
            }


  
}   }

