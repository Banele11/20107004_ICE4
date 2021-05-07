using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Order
    {
        public string Name { get; set; }
        public int Coffee { get; set; }
        public int Donuts { get; set; }
        public int Total { get; set; }

        public Order(string name, int coffee, int donuts)
        {
            this.Name = name;
            this.Coffee = coffee;
            this.Donuts = donuts;
            this.Total = CalcTotal(coffee, donuts);
        }

        private int CalcTotal(int coffee, int donuts)
        {
            int sum = coffee + donuts;
            return sum;
        }


    }
}
