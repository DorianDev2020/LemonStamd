using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Inventory
    {        
      
        public void AddLemonsToInventory() //ADD TO INVENTORY METHOD
        {
            for (int i = 0; i <lemons; i++)
			{
                Lemon lemon = new Lemon();
                lemons.AddToInventory(lemon);
			}
        
        }

         public void AddSugarCubesToInventory()
         {
            for (int i = 0; i < SugarCube>; i++)
			{
                SugarCube sugarCube = new SugarCube();
                SugarCubes.AddToInventory(sugarCube);


			}
        
         }

         public void AddIceCubesToInventory()
         {
            for (int i = 0; i < IceCube>; i++)
			{
                IceCube iceCube = new IceCube();
                IceCubes.AddToInventory(iceCube);

			}
        
         }

         public void AddCupsToInventory()
         {
            for (int i = 0; i <cups>; i++)
			{
                Cups cups = new Cups();
                Cups.AddToInventory(cup);

			}
        
         }

        public void RemoveLemonsFromInventory()         //REMOVE FROM INVENTORY
        {
            for (int i = 0; i  <lemons; i--)
			{
                Lemons lemons = new Lemons();
                lemons.RemoveFromInventory(lemon);

			}
        
        }

        public void RemoveCupsFromInventory()         
        {
            for (int i = 0; i  <lemons; i--)
			{
                Cups cups = new Cups();
                Cups.RemoveFromInventory(cup);

			}
        
        }

        public void RemoveIceCubesFromInventory()         
        {
            for (int i = 0; i  <lemons; i--)
			{
                IceCubes iceCubes = new IceCubes();
                iceCubes.RemoveFromInventory(iceCube);

			}
        
        }

        public void RemoveSugarCubesFromInventory()         
        {
            for (int i = 0; i  <lemons; i--)
			{
                SugarCubes sugarCubes = new SugarCubes();
                sugarCubes.RemoveFromInventory(sugarCube);

			}
        
        }

       


                                                    




















    }
}
