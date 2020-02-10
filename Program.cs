using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int contadorCartas= 2, cartas = 0, total =0;
            string seguir = "";
            int  cartaUno = 0;
            int cartaDos = 0;

            cartaUno = aleatorio.Next(1, 11);
            cartaDos = aleatorio.Next(1, 11);
            total = (cartaUno + cartaDos);

            Console.WriteLine("el valor de la carta Uno es:" + cartaUno + "y la carta Dos: " + cartaDos);
            Console.WriteLine("el total es: " + total);

            Console.WriteLine("¿nueva carta? (s/n)");
            seguir = Console.ReadLine();



            while (seguir == "s" && total < 21)
            {
                cartas = aleatorio.Next(1, 11);
                total = 

                if (total > 21)
                {
                    Console.WriteLine("Estas eliminado no puedes continuar");

                }
                else { 
                    total += cartas;
                    contadorCartas++;
                    Console.WriteLine("el valor de la carta o cartas es : " + cartas);
                    Console.WriteLine("el total de las cartas es: " + total);
                    Console.WriteLine("¿nueva carta? (s/n)");
                    seguir = Console.ReadLine();
                }


            }

            Console.WriteLine("el total de las cartas es: " + total);
            Console.WriteLine("garcias por participar");
            


        }
    }
}
