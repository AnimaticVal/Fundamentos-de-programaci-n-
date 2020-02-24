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
            double sen = 0;

            for (int i = 0; i < 1000; i++)
            {
                double numerador = Math.Pow(-1, i);
                double denominador = Factorial(2*i + 1);
                sen += (numerador / denominador) * Math.Pow(x,2*i+1 );

            }
            Console.WriteLine(sen);

        }
        public static double Factorial(double number) {
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
