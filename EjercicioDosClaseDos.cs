using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar datos 
            Console.WriteLine("ingrese d: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese b ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y");
            double y = double.Parse(Console.ReadLine());

            //operaciones 
            double bRad = (bGrados * (Math.PI / 180.0));
            double dRad = (dGrados * (Math.PI / 180.0));
            double e = Math.PI - (dRad + bRad);
            double c = Math.PI - e;
            double z = Math.Tan(c) * y;


            //salida
            Console.WriteLine("Z es igual a: " + z);


        }
    }
}
