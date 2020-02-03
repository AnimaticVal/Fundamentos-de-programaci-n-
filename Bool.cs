using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            Console.WriteLine("Votos por el partido A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos por el partido B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos en blanco");
            int blanco= int.Parse(Console.ReadLine());
            Console.WriteLine("Votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Vpoblacion total");
            int poblacion= int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de mayores de edad ");
            double porcentajeMayores = double.Parse(Console.ReadLine());

            //operaciones
           
            double mayores = (poblacion * porcentajeMayores) / 100;
            double votantes = (a + b + blanco + anulados);
            double abstencion = mayores- votantes; 

            bool condicionUno = anulados < (a + b)* 0.3;
            bool condicionDos = (a + b) > blanco;
            bool condicionTres = abstencion < votantes;
            


            if ((condicionUno || condicionDos) && condicionTres)
            {
                Console.WriteLine("votaciones fueron exitosas");
                if (a > b)
                {
                    Console.WriteLine("gana A");
                }
                else {
                    Console.WriteLine("gana B");
                
            }
            }
            else {
                Console.WriteLine("las votaciones deben hacerse nuevamente");
            }

           


        }
    }
}
