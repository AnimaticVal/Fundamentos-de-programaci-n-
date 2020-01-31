using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos 
            Console.WriteLine("ingrese su salario");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese 0 si su contrato es independiente");
            Console.WriteLine("ingrese 1 si su contrato es dependiente");
            int contr = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de SMMLV");
            double smm = double.Parse(Console.ReadLine());
            double arl = 0;
            double Bc = sal * 0.4;
            if (Bc < smm) { Bc = smm; }

            if (contr == 0)
            {

                Console.WriteLine("ingrese su nivel de riesgo");
                int nr = int.Parse(Console.ReadLine());

                if (nr == 1)
                {

                    arl = Bc * 0.00522;
                    //DEDUCCIONES 
                    double eps = Bc * 0.125;
                    double pension = Bc * 0.16;
                    double deducciones = eps + pension + arl;
                    //OPERACIONES
                    double salR = sal - deducciones;
                    double IngresosA = (salR * 12) ;
                    Console.WriteLine("sus deducciones son: " + deducciones);
                    Console.WriteLine("su salario mensual es de : " + salR);
                    Console.WriteLine("su salario anual es de : " + IngresosA);
                    

                }
                else if (nr == 2)
                {

                    arl = Bc * 0.01044;
                    double eps = Bc * 0.125;
                    double pension = Bc * 0.16;
                    double deducciones = eps + pension + arl;
                    //OPERACIONES
                    double salR = sal - deducciones;
                    double IngresosA = (salR * 12);
                    Console.WriteLine("sus deducciones son: " + deducciones);
                    Console.WriteLine("su salario mensual es de : " + salR);
                    Console.WriteLine("su salario anual es de : " + IngresosA);


                }
                else if (nr == 3)
                {
                    arl = Bc * 0.02436;
                    double eps = Bc * 0.125;
                    double pension = Bc * 0.16;
                    double deducciones = eps + pension + arl;
                    //OPERACIONES
                    double salR = sal - deducciones;
                    double IngresosA = (salR * 12);
                    Console.WriteLine("sus deducciones son: " + deducciones);
                    Console.WriteLine("su salario mensual es de : " + salR);
                    Console.WriteLine("su salario anual es de : " + IngresosA);


                }
                else if (nr == 4)
                {

                    arl = Bc * 0.04350;
                    double eps = Bc * 0.125;
                    double pension = Bc * 0.16;
                    double deducciones = eps + pension + arl;
                    //OPERACIONES
                    double salR = sal - deducciones;
                    double IngresosA = (salR * 12);
                    Console.WriteLine("sus deducciones son: " + deducciones);
                    Console.WriteLine("su salario mensual es de : " + salR);
                    Console.WriteLine("su salario anual es de : " + IngresosA);

                }
                else if (nr == 5) {

                    arl = Bc * 0.06960;
                    double eps = Bc * 0.125;
                    double pension = Bc * 0.16;
                    double deducciones = eps + pension + arl;
                    //OPERACIONES
                    double salR = sal - deducciones;
                    double IngresosA = (salR * 12);
                    Console.WriteLine("sus deducciones son: " + deducciones);
                    Console.WriteLine("su salario mensual es de : " + salR);
                    Console.WriteLine("su salario anual es de : " + IngresosA);


                }
            }
            else
            {

                //DEDUCCIONES 
                double eps = Bc * 0.04;
                double pension = Bc * 0.04;
                double deducciones = eps + pension;
                //OPERACIONES
                double salR = sal - (eps + pension);
                double IngresosA = (salR * 12) + sal;
                Console.WriteLine("sus deducciones son: " + deducciones);
                Console.WriteLine("su salario mensual es de : " + salR);
                Console.WriteLine("su salario anual es de : " + IngresosA);

            }












        }
    }
}
