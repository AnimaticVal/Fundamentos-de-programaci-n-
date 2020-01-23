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
            //ingresar datos 
            Console.WriteLine("ingrese el lado Z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el angulo C: ");
            double cGrados = double.Parse(Console.ReadLine());

            //operaciones 

            double c = (cGrados * (Math.PI / 180.0));
            double y = z / Math.Tan(c);
            double t = Math.Sqrt(z * z + y * y);
            double a = 180.0 - (90 + cGrados);

            //salida
            Console.WriteLine("el lado Y es: " + y);
            Console.WriteLine("el lado T es: " + t);
            Console.WriteLine("el angulo a es: " + a);
        }
    }
}
