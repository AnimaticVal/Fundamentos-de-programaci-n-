using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            string seguir = "";
            string continuar = "";
            int dadoUno = 0;
            int contadorVidas = 3;
            int contadorUnos = 0;
            int total = 0;
            int condicion6 = 0;
            int dadosEspeciales = 2;
            int dadoE1 = 0;
           

            dadoUno = aleatorio.Next(1, 7);
            total = dadoUno;


            Console.WriteLine("el valor del dado uno : " + dadoUno);
            Console.WriteLine("el total es: " + total);
            Console.WriteLine("tienes: " + contadorVidas + " vidas");

            Console.WriteLine("¿Desea tirar otra vez? (s/n)");
            seguir = Console.ReadLine();
            

            while (seguir == "s" && total < 100)
            {
                

                Console.WriteLine("¿Desea tirar dados especiales? (m)");
                continuar = Console.ReadLine();
                if (continuar == "m" && (dadosEspeciales <= 1 && dadosEspeciales <= 2))
                {

                    dadoE1 = aleatorio.Next(1, 13);

                    total += dadoE1;
                    dadosEspeciales--;
                }
                else {
                    dadoUno = aleatorio.Next(1, 7);
                    total += dadoUno;
                }
                
             
                    if (dadoUno == 1) contadorUnos++;
                    if (contadorUnos == 2)
                    {
                        contadorVidas -= 1;
                        total -= 10;
                        contadorUnos = 0;
                    }

                    if (dadoUno != 6) { condicion6 = 0; } else { condicion6++; }

                if (condicion6 == 2 && contadorVidas < 3)
                {
                    contadorVidas++;
                    condicion6 = 0;
                }


                    Console.WriteLine("el valor del dado: " + dadoUno);
                    Console.WriteLine("el total actual es: " + total);
                    Console.WriteLine("tienes: " + contadorVidas + " vidas");



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

