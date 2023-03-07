using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prjSingleton
{
    public class Lunch
    {
        private static Lunch instance;
        int count = 0;
        String LunchOrder = "";
        private Lunch()
        {
            LunchOrder = "Egg on the floor";
        }
        public static Lunch getInstance()
        {
            if(instance == null)
            {
                instance = new Lunch();
            }
            return instance;
        }
        public void setLunchOrder(String Order)
        {
            this.LunchOrder = Order;
        }
        public String getLunchOrder()
        {
            return this.LunchOrder;
        }
    }
}
