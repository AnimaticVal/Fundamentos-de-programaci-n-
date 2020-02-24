using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int cartas = 0, total = 0, intentos = 0, max = 0, ganador = 0;
            string seguir = "";
            int turnos = 0;
            int jugadores = 0;
            bool inicio = true;
            int cartaUno = 0;
            int cartaDos = 0;




            Console.WriteLine("ingrese el número de jugadores entre 2 y 5");
            jugadores = int.Parse(Console.ReadLine());


            while (jugadores < 2 || jugadores > 5)
            {

                Console.WriteLine("Error ");
                inicio = false;
                Console.WriteLine(" intente de nuevo ");
                jugadores = int.Parse(Console.ReadLine());


            }



            if (inicio)
            {
                while (turnos < jugadores)
                {

                    Console.WriteLine("INICIA JUEGO, puede continuar");//inicia el juego 
                    Console.WriteLine("Bienvenido jugador " + (turnos + 1));// turno jugado

                    cartaUno = aleatorio.Next(1, 11);
                    cartaDos = aleatorio.Next(1, 11);
                    total = (cartaUno + cartaDos);

         

                    Console.WriteLine("el valor de la carta Uno es: " + cartaUno + " y la carta Dos: " + cartaDos);
                    Console.WriteLine("el total es: " + total);

                    Console.WriteLine("¿desea tirar una carta? (s/n)");
                    seguir = Console.ReadLine();
                    while (seguir != "s" && seguir != "n")
                    {
                        Console.WriteLine("error");
                        Console.WriteLine("¿desea tirar una carta? (s/n)");
                        seguir = Console.ReadLine();
                    }


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
                            while (seguir != "s" && seguir != "n")
                            {
                                Console.WriteLine("error");
                                Console.WriteLine("¿desea tirar una carta? (s/n)");
                                seguir = Console.ReadLine();
                            }

                        }
                        else
                        {


                            Console.WriteLine("Estas eliminado no puedes continuar");
                        }


                    }

                    if (total > max)
                    {
                        max = total;
                        turnos = ganador;

                    }


                    Console.WriteLine("el total de las cartas es: " + total);
                    Console.WriteLine("garcias por participar");
                    turnos++;
                }

                Console.WriteLine("el ganador es: " + (ganador+1) + " con " + max + " puntos");
            }
        }
    }
}
