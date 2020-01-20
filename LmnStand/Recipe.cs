using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    class Recipe
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
    }
}
