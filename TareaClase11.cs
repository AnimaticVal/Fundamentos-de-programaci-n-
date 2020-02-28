
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double distancias= 0, max= 0;
            double[] coordsX = { 0, 2, 3, 7 };
            double[] coordsY = { 0, 1, 5, 6 };

            double pAB = (coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]);
            double pBC = (coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]);
            double pCD = (coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]);
            double pAD = (coordsY[3] - coordsY[0]) / (coordsX[3] - coordsX[0]);

            if ((pAB == pBC) && (pCD == pAD) && (pBC == pCD) && (pAB == pAD))
            {
                Console.WriteLine("estan sobre la misma linea");
            }
            else
            {
                Console.WriteLine("No estan sobre la misma linea");
            }

            for (int i = 0; i < 3; i++)
            {
                distancias = Math.Sqrt((Math.Pow((coordsX[i + 1] - coordsX[i]), 2)) + (Math.Pow((coordsY[i + 1] - coordsY[i]), 2)));
               
                if (distancias > max) max = distancias;
               
            }
            double distanciaAD = Math.Sqrt((Math.Pow((coordsX[3] - coordsX[0]), 2)) + (Math.Pow((coordsY[3] - coordsY[0]), 2)));
            if (distanciaAD > max) max = distanciaAD;
            Console.WriteLine("La distancia maxima es " + max);
        }
        
    }
}
