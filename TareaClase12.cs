using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int cartas = 0, total = 0, turnos = 0,jugador=0, ganador= 0, max= 0, maxDos= 0, minDiferencia=200, diferencia = 200;
            string seguir = "";
            int cartaUno = 0;
            int cartaDos = 0;
           
            

            Console.WriteLine("Escriba el numero de jugadores");
            int n = int.Parse(Console.ReadLine());
            int[] puntajes = new int[n];


            while (turnos < n)
            {
              Console.WriteLine("Bienvenido jugador " + (turnos + 1));

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
                    Console.WriteLine("su nueva carta es: " + cartas);
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
                Console.WriteLine("gracias por participar");
                
                puntajes[turnos] = total;
                
                if ((total > max) && total <=21)
                {
                    max = total;
                    ganador = turnos +1;

                }
                
                turnos++;
            }
            for (int j = 0; j < n; j++)
            {
                minDiferencia = max - puntajes[j];
                if ((diferencia < minDiferencia) && (diferencia != 0) && puntajes[j] <= 21)
                {
                    diferencia = minDiferencia;
                    maxDos = (j + 1);
                }
            }
            for (int i = 0; i < n; i++) Console.WriteLine("jugador:  " + (i + 1) + "  tubo un puntaje de: " + puntajes[i]);
            Console.WriteLine("el ganador es: " + ganador);
            Console.WriteLine("el segundo lugar  es: " + maxDos);

        }

    }
}
