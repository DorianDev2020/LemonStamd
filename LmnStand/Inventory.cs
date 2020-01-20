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
        public string name;
        public string name;
        public void AddLemonsToInventory() //ADD TO INVENTORY METHOD
=======
    public class Inventory : Item
    {
        
        public List<Lemon> lemons;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;

        public Inventory() 
>>>>>>> 79349588c155bbff91662e27a6b5bb1cde088567
        {
            
        
        }

<<<<<<< HEAD
         public void AddSugarCubesToInventory()
         {
            for (int i = 0; i <SugarCube>; i++)
			{
                SugarCube sugarCube = new SugarCube();
                SugarCubes.AddToInventory(sugarCube);
=======
>>>>>>> 79349588c155bbff91662e27a6b5bb1cde088567

        public void AddToInventory() 
        {
            //Lemon lemons = new Lemon(100);
            //lemons.AddLemon(Lemons);

           







        }

        public void RemoveFromInventory() 
        {

        
        
        
        
        
        
        
        
        }

        

       


                                                    




















    }
}
