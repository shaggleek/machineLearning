using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace machineLearning
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader datos = new StreamReader(File.OpenRead(@"/Users/shaggleek/Desktop/Task/flores.csv"));

            //Crear listas para almacenar valores
            List<String> sepalLength = new List<String>();
            List<String> sepalWidth = new List<String>();
            List<String> petalLength = new List<String>();
            List<String> petalWidth = new List<String>();
            List<String> species = new List<String>();

            //Recorrer archivo y almacenar datos en listas
            while (!datos.EndOfStream)
            {
                string linea = datos.ReadLine();
                if (!String.IsNullOrWhiteSpace(linea))
                {
                    string[] valor = linea.Split(',');

                    if (valor.Length >= 4)
                    {
                        sepalLength.Add(valor[0]);
                        sepalWidth.Add(valor[1]);
                        petalLength.Add(valor[2]);
                        petalWidth.Add(valor[3]);
                        species.Add(valor[4]);
                    }
                }
            }
        }
    }
}