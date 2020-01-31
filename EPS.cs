using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ingrese la cantidad de salarios mínimos: ");
            double smm = double.Parse(Console.ReadLine());
            ;

            //operaciones 

            if (smm <= 2)
            {

                Console.WriteLine("Su tarifa es la A");

            }
            else if (2 < smm && smm < 5)
            {

                Console.WriteLine("Su tarifa es la B");
            }
            else
            {

                Console.WriteLine("Su tarifa es la C");

            }
        }
    }
}
