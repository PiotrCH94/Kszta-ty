using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
    class Kwadrat:Prostokat
    {
        public Kwadrat(double abcd)
        {
            this.a = abcd;
            this.b = abcd;
            this.c = abcd;
            this.d = abcd;
        }
    }
}
