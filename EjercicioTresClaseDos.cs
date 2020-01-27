using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //ingresar datos 
            Console.WriteLine("ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese d ");
            double dGrados= double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese x");
            double x = double.Parse(Console.ReadLine());

            //operaciones 
            double dRad = (dGrados * (Math.PI / 180.0));
            double y = (Math.Cos(dRad) * w) - x;



            //salida
            Console.WriteLine("y es igual a: " + y);

        }
    }
}
