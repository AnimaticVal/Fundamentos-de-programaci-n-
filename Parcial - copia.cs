using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double suma = 0;
        double promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            promedio = suma / notas.Length;
        }
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > promedio + 0.5) {
                salida++;
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double suma = 0;
        double promedio = 0;
        double lejano = 0;
        string notasLejos = "";
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            promedio = suma / notas.Length;
        }
        double desviacionInd = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            desviacionInd = Math.Sqrt(Math.Pow((notas[i] - promedio), 2));
            for (int a = 0; a < 5; a++)
            { 
                if (desviacionInd > lejano)
                {
                    lejano = notas[a];
                    notasLejos = salida[a];

                }
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------




        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------




        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double longitud = notas.Length;
        double mitad = longitud / 2;
        double mediana = 0;

        //ENCONTRAR LA MEDIANA
        for (int j = 0; j < notas.Length; j++) // organizar datos
        {
            for (int i = 0; i < notas.Length - 1; i++)
            {
                if (notas[i] > notas[i + 1])
                {
                    double temp = notas[i];
                    notas[i] = notas[i + 1];
                    notas[i + 1] = temp;

                    string temp2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = temp2;
                }
            }
        }
        if (longitud % 2 == 0)
        {
            mediana = (notas[(int)mitad - 1] + notas[(int)mitad]) / 2;
        }
        else
        {
            mediana = notas[(int)mitad];
        }
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > mediana + 0.5)
            {
                salida.Add(nombres[i]);
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double suma = 0;
        double promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            promedio = suma / notas.Length;
        }
        for (int i = 0; i < nombres.Length - 1; i++)
        {
            nombres[i] = nombres[i].ToUpper();
        }
     
        for (int j = 0; j < nombres.Length; j++)
        {
            for (int i = 0; i < nombres[j].Length; i++)
            {
                if (nombres[j][i] == 'A')
                {
                    salida.Add(nombres[j]);
                    break;
                }
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }
}


