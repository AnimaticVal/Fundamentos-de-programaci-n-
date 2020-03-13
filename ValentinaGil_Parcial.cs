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
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        promedio = total / notas.Length;
        //CONDICIONAL 
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= 1.25 * promedio)
            {
                salida++;
            }
        }


        //FIN PROMEDIO



        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[3];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
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
        for (int i = 0; i < nombres.Length; i++)//recorro nomnres
        {

            for (int j = 0; j < nombres[i].Length; j++)//RECORRO LAS LETRAS
            {
                int final = nombres[i].Length - 1;

                if (nombres[i][final] == 'A' || nombres[i][final] == 'E' || nombres[i][final] == 'I' || nombres[i][final] == 'O' || nombres[i][final] == 'U')
                {
                    for (int a = 0; a < salida.Length; a++)
                    {

                        salida[a] = nombres[j];

                    }
                }

            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }


    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        //PROMEDIO
        double total = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        promedio = total / notas.Length;
        for (int i = 0; i < nombres.Length; i++)//RECORRO LOS NOMBRES
        {
          
           
            if ((nombres[i][0] == 'A' || nombres[i][0] == 'E' || nombres[i][0] == 'I' 
                || nombres[i][0] == 'O' || nombres[i][0] == 'U')&& notas[i]>promedio)
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
        for (int i = 0; i < nombres.Length; i++)//RECORRO LOS NOMBRES
        {
            int contador = 0;
            for (int j = 0; j < nombres[i].Length; j++)//RECORRO LAS LETRAS
            {
                if (nombres[i][j] == 'A' || nombres[i][j] == 'E' || nombres[i][j] == 'I' || nombres[i][j] == 'O' || nombres[i][j] == 'U')
                {
                    contador++;
                }
            }
            int letras = nombres[i].Length - contador;
            if (letras >= 5)
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


