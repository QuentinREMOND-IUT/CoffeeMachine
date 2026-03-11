using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemondQuentin_TP4
{
    public class Distribution
    {
        private int coffee;
        private int water;
        private int sugar;

        public int Coffee { get => coffee;}
        public int Water { get => water;}
        public int Sugar { get => sugar;}
        public double Cost { get => 0.70*coffee + 0.01*water +0.10*sugar;}

        public Distribution (int coffee, int water, int sugar)
        {
            this.coffee = coffee;
            this.water = water;
            this.sugar = sugar;
        }
    }
}
