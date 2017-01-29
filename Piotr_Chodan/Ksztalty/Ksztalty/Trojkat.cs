using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
    class Trojkat:Ksztalt
    {
        public void pusty()
        {

        }

        public Trojkat(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double ObliczObwod()
        {
            double obwod = 0;
            return obwod = a + b + c;
        }
        public override double ObliczPole()
        {
            double p = 0;
            double pole = 0;
            p = ObliczObwod() / 2;
            return pole = Math.Sqrt((p* - a) * (p - b) * (p - c));
        }
       
    }
}
