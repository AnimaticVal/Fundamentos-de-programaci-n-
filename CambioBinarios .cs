using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseDos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos 
            Console.WriteLine("ingrese b0");
            double b0 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese b1");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese b2");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese b3");
            double b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese b4");
            double b4 = double.Parse(Console.ReadLine());

            //operaciones 
            double entero = ((b0) * (Math.Pow(2, 0))) + ((b1) * (Math.Pow(2, 1))) +  ((b2) * (Math.Pow(2, 2))) + ((b3) * (Math.Pow(2, 3))) + ((b4) * (Math.Pow(2, 4)));

            //salida
            Console.WriteLine("El número es: "+ entero);


        }
    }
}
