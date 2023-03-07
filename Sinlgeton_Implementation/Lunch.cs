using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinlgeton_Implementation
{
    public class Lunch
    {
        private static Lunch instance;
        int count = 0;

        string LunchOrder = "";

        private Lunch()
        {
            LunchOrder = "Egg on the floor";
        }

        public static Lunch getInstance()
        {

            if (instance == null)
            {
                instance = new Lunch();
            }
            return instance;
        }

        public void setLunchOrder(string Order)
        {
            this.LunchOrder = Order;
        }

        public string getLunchOrder()
        {
            return this.LunchOrder;
        }
    }
}
