using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)

        {

            Random aleatorio = new Random();
            string seguir = "";
            int dado = 0;
            int dadoDos = 0;
            int contadorVidas = 3;
            int turnos = 0;
            int total = 0;

            Console.WriteLine("¿Desea tirar el dado? (s/n)");
            seguir = Console.ReadLine();


            while (seguir == "s" && total < 100)
            {

                dado = aleatorio.Next(1, 7);
                total += dado;
                turnos += 1;

                Console.WriteLine("el valor del dado es : " + dado);
                Console.WriteLine("el total es: " + total);
                Console.WriteLine("tienes: " + contadorVidas + " vidas");
                Console.WriteLine("estas en el turno: " + turnos);

                if ((turnos % 2 == 0)) contadorVidas--;

                if ((turnos % 4 == 0))
                {
                    dadoDos = aleatorio.Next(1, 7);
                    total += dadoDos;
                    Console.WriteLine("el valor del dado dos es : " + dadoDos);
                    Console.WriteLine("el nuevo total es: " + total);

                    if (dado == dadoDos && contadorVidas < 3) contadorVidas++;
                }
                

                if (total >= 100)
                {
                    Console.WriteLine("Has Ganado");
                    break;

                }
                else if (contadorVidas == 0)
                {
                    Console.WriteLine("Has perdido");
                    break;
                }
                else
                {

                    Console.WriteLine("¿Desea tirar otra vez? (s/n)");
                    seguir = Console.ReadLine();

                }



            }
            Console.WriteLine("el total del dado es: " + total);
            Console.WriteLine("gracias por participar");











        }
    }
}
