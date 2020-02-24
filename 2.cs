using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de x");
            double x = double.Parse(Console.ReadLine());
            double e = 0;

            for (int i = 0; i < 100; i++)
            {
                double numerador = Math.Pow(x, i);
                double denominador = Factorial(i);
                e += (numerador / denominador) ;

            }
            Console.WriteLine(e);

        }
        public static double Factorial(double number) {
            if (number == 0) return 1;
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
