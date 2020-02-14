using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int  cartas = 0, total = 0;
            string seguir = "";
            int cartaUno = 0;
            int cartaDos = 0;

            cartaUno = aleatorio.Next(1, 11);
            cartaDos = aleatorio.Next(1, 11);
            total = (cartaUno + cartaDos);

            Console.WriteLine("el valor de la carta Uno es: " + cartaUno + " y la carta Dos: " + cartaDos);
            Console.WriteLine("el total es: " + total);

            Console.WriteLine("¿nueva carta? (s/n)");
            seguir = Console.ReadLine();



            while (seguir == "s" && total < 21)
            {
                cartas = aleatorio.Next(1, 11);
                total += cartas;
                Console.WriteLine("su nueva carta es: "+ cartas);
                Console.WriteLine("su nuevo total es:" + total);

                if (total <= 21)
                {
                  
                    
                    Console.WriteLine("¿nueva carta? (s/n)");
                    seguir = Console.ReadLine();

                }
                else 
                {


                    Console.WriteLine("Estas eliminado no puedes continuar");
                }


            }

            Console.WriteLine("el total de las cartas es: " + total);
            Console.WriteLine("garcias por participar");
        }
    }
}
