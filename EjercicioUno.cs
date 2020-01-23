using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            //ingresar datos 
            Console.WriteLine("ingrese el lado Y");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el lado Z");
            double z = double.Parse(Console.ReadLine());

            //Operacines
            double t = Math.Sqrt((y*y)+(z*z));
            double a = Math.Asin(y/t);
            double c = Math.Asin(z/t);

            double conversion1 = (a * 180.0) / Math.PI;
            double conversion2 = (c * 180.0) / Math.PI;

            //Salida de datos 
            Console.WriteLine("el lado T o hipotenusa es: " + t);
            Console.WriteLine(" Sus angulos son: " + "90°" + " " + conversion1 + "° " + conversion2 + "°");

        }
    }
}
