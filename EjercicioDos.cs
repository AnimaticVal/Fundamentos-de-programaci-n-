using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar datos 
            Console.WriteLine("ingrese el lado T: ");
            double t = double.Parse(Console.ReadLine());
           Console.WriteLine("ingrese el angulo A: ");
            double aGrados = double.Parse(Console.ReadLine());

            //operaciones 

            double a =(aGrados *(Math.PI/ 180.0));
            double y = t * Math.Sin(a);
            double z = t * Math.Cos(a);
            double c = 180.0  - (90 + aGrados);

            //salida
            Console.WriteLine("el lado Y es: "+ y);
            Console.WriteLine("el lado Z es: " + z);
            Console.WriteLine("el angulo c es: " + c);


        }
    }
}
