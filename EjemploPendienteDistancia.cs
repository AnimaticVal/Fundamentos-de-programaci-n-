using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //ingreso edad
           
            Console.Write("ingrese x1: ");
            double x1 =  double.Parse(Console.ReadLine());
            Console.Write("ingrese x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("ingrese y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double pendiente = (y2 - y1) / (x2 - x1);
            double intercepto = y1 - (pendiente * x1);
            double distancia = Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));


            Console.WriteLine("La pendiente es: " + pendiente + " El intercepto es: " + intercepto + " La distancia es: " + distancia);



            //Console.WriteLine(z);
        }
    }
}
