using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmnStand
{
    public class Customer : Inventory //Member Variables
    {
        public int Buyer;
        public double MoneyMadeToday;
        public Random BuyChances;
        public Customer()
        {
            Buyer = 0;
            MoneyMadeToday = 0;
            BuyChances = new Random();
        }
        
    }
}
