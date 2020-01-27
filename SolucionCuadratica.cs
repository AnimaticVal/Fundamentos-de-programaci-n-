using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ingrese a: ");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese b");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese c");

            double c = double.Parse(Console.ReadLine());

            double d = (Math.Pow(b, 2) - (4*a*c));
         


            if (d == 0)
            {

                double su = -b / (2 * a);

                Console.WriteLine("tiene solucion única" + su);
            }
            else if (d > 0) {
                

                 double s1 = (-b + Math.Sqrt(d)) / (2 * a);
                double s2 = (-b  - Math.Sqrt(d)) / (2 *a );
                Console.WriteLine("solución Uno:" + s1 );
                Console.WriteLine("solución Dos:" + s2);

            } else {
                Console.WriteLine("No tiene solución");


            }


        }
    }
}
