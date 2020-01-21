using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Wallet
    {


        private readonly double money;   //field
        public double Money    //property
        {
            get => money;

            set => Money = value;





        }




        public Wallet()
        {

            this.money = 100;
               

        }
        
        
        

      
        public void SetupWallet()
        {
            if (Money <= 0)
            {
                Console.WriteLine("You are all out of money!");
                
            }


            else if (Money == 100)
            {
                Console.WriteLine("");
            }






        }



    }
    
    
}
