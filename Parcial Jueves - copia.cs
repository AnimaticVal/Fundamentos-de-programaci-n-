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
        //PROMEDIO
        double total = 0, promedio = 0; 
        for (int i = 0; i < notas.Length; i++) {
            total += notas[i];
        }
        promedio = total / notas.Length;
        double[] desviaciones = new double[notas.Length];
        //FIN PROMEDIO
        //DESVIACION
        total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            desviaciones[i] = Math.Pow((notas[i] - promedio), 2);
            total += desviaciones[i];
        }
        double desviacion = Math.Sqrt(total / notas.Length);
        //FIN DESVIACION
        //CONDICIONAL 
        for (int i = 0; i < notas.Length; i++)
        {
            if (promedio - desviacion < notas[i] && notas[i] < promedio + desviacion) {
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
        //PROMEDIO
        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        promedio = total / notas.Length;
        double[] desviaciones = new double[notas.Length];
        //FIN PROMEDIO
        //DESVIACION
        total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            desviaciones[i] = Math.Pow((notas[i] - promedio), 2);
            total += desviaciones[i];
        }
        double desviacion = Math.Sqrt(total / notas.Length);
        //FIN DESVIACION
        double suma = promedio + desviacion;
        double[] distancias = new double[notas.Length];
        for (int i = 0; i < notas.Length; i++)
        {
            distancias[i] = Math.Abs(notas[i] - suma);
        }

        //ORGANIZAR DISTANCIAS 
        for (int j = 0; j < notas.Length; j++)
        {
            for (int i = 0; i < notas.Length - 1; i++)
            {
                if (distancias[i] > distancias[i + 1])
                {
                    double temp = distancias[i];
                    distancias[i] = distancias[i + 1];
                    distancias[i + 1] = temp;

                    string temp2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = temp2;
                }
            }
        }
        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }

        //FIN DE ORDENAMIENTO



        //- Arriba de esta línea va su código --------
        return salida;
    }


    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        promedio = total / notas.Length;
        double[] desviaciones = new double[notas.Length];
        //FIN PROMEDIO
        //DESVIACION
        total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            desviaciones[i] = Math.Pow((notas[i] - promedio), 2);
            total += desviaciones[i];
        }
        double desviacion = Math.Sqrt(total / notas.Length);
        //FIN DESVIACION
        //CONDICIONAL 
        for (int i = 0; i < notas.Length; i++)
        {
            if (promedio - desviacion < notas[i] && notas[i] < promedio + desviacion)
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

       
        for (int i = 0; i < nombres.Length; i++)
        {
            int contador = 0;
            for (int j = 0; j < nombres[i].Length; j++)
            {
                if (nombres[i][j] == 'A' || nombres[i][j] == 'E' || nombres[i][j] == 'I' || nombres[i][j] == 'O' || nombres[i][j] == 'U')
                {
                    contador++;
                }
            }
            if (3 <= contador && notas[i] > 3)
            { 
                salida.Add(nombres[i]);
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
}


