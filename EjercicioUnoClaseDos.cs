using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar datos 
            Console.WriteLine("ingrese b: ");
            double bGrados= double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese z ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y");
            double y = double.Parse(Console.ReadLine());


            //operaciones 

            double bRad = (bGrados * (Math.PI / 180.0));
            double t = Math.Sqrt((z * z) + (y * y));
            double c = Math.Atan(z / y);
            double e = Math.PI - c;
            double d = Math.PI - (e + bRad);
            double w = (t * Math.Sin(e)) / Math.Sin(d);
            double x = (t * Math.Sin(bRad)) / Math.Sin(d);


            
            //salida
            Console.WriteLine("x es igual a: " + x);
            

        }
    }
}
