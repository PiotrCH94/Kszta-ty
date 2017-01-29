using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksztalt> figury = new List<Ksztalt>();
            figury.Add(new Czworokat(1, 2, 3, 4));
            figury.Add(new Czworokat(2, 3, 4, 5));
            figury.Add(new Czworokat(3, 4, 5, 6));
            figury.Add(new Czworokat(4, 5, 6, 7));
            figury.Add(new Prostokat(5,6));
            figury.Add(new Prostokat(9, 8));
            figury.Add(new Prostokat(15,2));
            figury.Add(new Prostokat(3,5));
            figury.Add(new Kwadrat(5));
            figury.Add(new Kwadrat(3));
            figury.Add(new Trojkat(1, 2, 3));
            figury.Add(new Trojkat(8, 4, 1));
            figury.Add(new TrojkatProstokatny(4,5));
            figury.Add(new Trojkat(1, 2, 3));
            figury.Add(new Trojkat(1, 6, 3));
            figury.Add(new Trojkat(5, 2, 3));
            figury.Add(new TrojkatRownoboczny(14));
            figury.Add(new TrojkatRownoboczny(9));
            figury.Add(new TrojkatProstokatny(9, 12));
            figury.Add(new TrojkatProstokatny(5, 8));
            foreach(var figurka in figury)
            {

                if(figurka.ObliczPole() > 10)
                {
                    Console.WriteLine(figurka.ToString());
                }
             foreach ( var figura in figury)
             {
                 if(figurka.ObliczObwod() <= 20)
                 {
                     Console.WriteLine(figurka.ToString());
                 }
             }
            }
        }
    }
}
