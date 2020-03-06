using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese una frase");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            string[] Palabras = frase.Split(' ');
            int contador = 0;

            Console.WriteLine("ingrese una palabra que quiere buscar");
            string palabra = Console.ReadLine();
            palabra= palabra.ToUpper();
      

            for (int i = 0; i < Palabras.Length ; i++)
            {
                if (palabra == Palabras[i])
                {
                    contador++;
                    Console.WriteLine("la palabra está en posicion: " + i);
                } 
          
            }
            Console.WriteLine("y se repite:" + contador + "veces");

        }
    }
}
