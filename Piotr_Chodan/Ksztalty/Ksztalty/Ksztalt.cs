using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
    abstract class Ksztalt
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;

        public void domyslny()
        { 
        }

        abstract public double ObliczPole();
        abstract public double ObliczObwod();

        public override string ToString()
        {
            return "Obwod: " + ObliczObwod() + ",Pole: " + ObliczPole();
        }
    }
}
