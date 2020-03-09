using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 9, 6};
            int[] B = { 0, 4, 18, 6, 16, 6, 2, 10, 14, 12, 8 ,2 };
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,
                        17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
            //UNION
            //Agregar los elementos a las listas
            List<int> union = new List<int>();
            for (int i = 0; i < A.Length; i++) {
                union.Add(A[i]);//agregar valores del conjunto A 
            }
            for (int i = 0; i < B.Length; i++)
            {
                union.Add(B[i]);//agregar valores del conjunto B
            }
            union.Sort();//ordenar los datos
            for(int i = 0; i < union.Count -1; i++) //eliminar datos repetidos
            {
                if (union[i] == union[i + 1]) {
                    union.RemoveAt(i);
                    i = 0;
                }
            }
            for(int i = 0; i < union.Count; i++)
            {
                Console.WriteLine(union[i]);
            }
            Console.WriteLine();
            //INTERSECCION 
            List<int> interseccion = new List<int>();
            for (int i = 0; i < A.Length; i++)//recorrer A
            {
                for (int j = 0; j < B.Length; j++)//Recorrer B
                {
                    if (A[i] == B[j])
                    {
                        interseccion.Add(A[i]);//agregar a interseccion
                    }
                }
            }
            interseccion.Sort();//organizar datos 
            for (int i = 0; i < interseccion.Count - 1; i++) //eliminar datos repetidos
            {
                if (interseccion[i] == interseccion[i + 1])
                {
                    interseccion.RemoveAt(i);
                    i = 0;
                }
            }
            for (int i = 0; i < interseccion.Count; i++)
            {
                Console.WriteLine(interseccion[i]);
            }
            Console.WriteLine();

            //COMPLEMENTO
            List<int> complemento = new List<int>();
            for (int i = 0; i < U.Length; i++)
            {
                complemento.Add(U[i]);//agregar valores del conjunto U
            }
            complemento.Sort();//organizar datos 
            for (int i = 0; i < complemento.Count; i++)//recorrer complento
            {
                for (int j = 0; j < union.Count; j++)//Recorrer B
                {
                    if (complemento[i] == union[j])//comparar y enviar 
                    {
                        complemento.RemoveAt(i);
                        i = 0;
                    }
                }
            }

            for (int i = 0; i < complemento.Count; i++)
            {
                Console.WriteLine(complemento[i]);
            }

        }
    }
}
