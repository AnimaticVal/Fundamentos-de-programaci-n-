using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("ingrese el numero de datos: ");
            int n = int.Parse(Console.ReadLine());
            int i=0, max= 0, min = 200;
            string nombre = "", mayor = "M", menor = "m";


            while (i < n) {
                Console.WriteLine("ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    mayor = nombre;
                }
                if (edad < min) {
                    min = edad;
                    menor = nombre;
                }
                  
                total += edad;
                i++;

            }
            double promedio = total / n;
            Console.WriteLine("Promedio es:" + promedio);
            Console.WriteLine("el mayor es:"+ mayor + "con edad: "+ max);
            Console.WriteLine("el menor es :" + menor  + "con edad: " + min);
        }
    }
}
