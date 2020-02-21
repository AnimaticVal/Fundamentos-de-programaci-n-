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
            Random aleatorio = new Random();
            int cartas = 0, total = 0, intentos = 0;
            string seguir = "";
            int uno = 0, dos = 0;
            int sumaCorrecta = 0;
            int respuesta = 0;
            bool inicio = true;
            int cartaUno = 0;
            int cartaDos = 0;


            uno = aleatorio.Next(1, 11);
            dos = aleatorio.Next(1, 11);
            Console.WriteLine("para daber si eres humano responda haga la siginete suma " + uno + "+" + dos);
            respuesta = int.Parse(Console.ReadLine());
            sumaCorrecta = uno + dos;

            while (respuesta != sumaCorrecta)
            {
                intentos++;
                if (intentos <3)
                {
                    Console.WriteLine("Error, intente de nuevo ");
                    uno = aleatorio.Next(1, 11);
                    dos = aleatorio.Next(1, 11);

                    Console.WriteLine("sume: " + uno + "+" + dos);
                    respuesta = int.Parse(Console.ReadLine());
                    sumaCorrecta = uno + dos;
                }
                else
                {
                    Console.WriteLine("validacion incorrecta no puede continuar ");
                    inicio = false;
                    break;


                }
            }

            if (inicio)
            {
                Console.WriteLine("INICIA JUEGO, puede continuar");//inicia el juego 

                cartaUno = aleatorio.Next(1, 11);
                cartaDos = aleatorio.Next(1, 11);
                total = (cartaUno + cartaDos);

                Console.WriteLine("el valor de la carta Uno es: " + cartaUno + " y la carta Dos: " + cartaDos);
                Console.WriteLine("el total es: " + total);

                Console.WriteLine("¿desea tirar una carta? (s/n)");
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
                Console.WriteLine("garcias por participar");
            }
        }
    }
}
