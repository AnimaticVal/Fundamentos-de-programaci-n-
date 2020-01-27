using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //ingresar datos 
            Console.WriteLine("ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese t ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese c");
            double cGrados= double.Parse(Console.ReadLine());

            //operaciones 
            double cRad = (cGrados * (Math.PI / 180.0));
            double e = Math.PI - cRad;
            double d = Math.Asin(t * Math.Sin(e) / w);
            double b = Math.PI - (d + e);
            double x = (w * Math.Sin(b)) / Math.Sin(e);



            //salida
           Console.WriteLine("x es igual a: " + x);




        }
    }
}
