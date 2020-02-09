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
            Console.WriteLine("ingrese su salario");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese 0 si su contrato es independiente");
            Console.WriteLine("ingrese 1 si su contrato es dependiente");
            int contrato = int.Parse(Console.ReadLine());
            double smm = 877803, arl = 0, eps = 0, pension = 0, prima = 0;
            double baseDeCotización = salario * 0.4;
            if (baseDeCotización <= smm) baseDeCotización = smm;

            switch (contrato)
            {
                case 1:
                    eps = 0.04 * baseDeCotización;
                    pension = 0.04 * baseDeCotización;
                    prima = salario;
                    break;
                default:
                    eps = 0.125 * baseDeCotización;
                    pension = 0.16 * baseDeCotización;
                    Console.WriteLine("ingrese su niel de riesgo");
                    double riesgo = double.Parse(Console.ReadLine());
                    switch (riesgo) {
                        case 1:
                            arl = baseDeCotización * 0.00522;
                            break;
                        case 2:
                            arl = baseDeCotización * 0.01044;
                            break;
                        case 3:
                            arl = baseDeCotización * 0.02436;
                            break;
                        case 4:
                            arl = baseDeCotización * 0.04350;
                            break;
                        case 5:
                            arl = baseDeCotización * 0.06960;
                            break;
                    }
                    break;//no tocar 
            }
          
            double salarioReal = salario - (arl+ pension+ eps);
            double IngresosAnuales = (salarioReal * 12) + prima;

            Console.WriteLine("su salario es de: " + salarioReal);
            Console.WriteLine("su salario anual es de: " + IngresosAnuales);




        }
    }
}
