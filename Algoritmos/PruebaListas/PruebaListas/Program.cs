using System;
using System.Collections.Generic;

namespace PruebaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 6 9 8 1 6 10

            //int[] Valores = new int[6];
            //Valores[0] = 5;
            //Valores[1] = 6;
            //Valores[2] = 9;
            //Valores[3] = 8;
            //Valores[4] = 1;
            //Valores[5] = 6;
            //Array.Resize(ref Valores, 7);           // Ineficaz
            //Valores[6] = 10;
            //for (int i = 0; i < Valores.Length; i++)
            //{
            //    Console.WriteLine(Valores[i]);
            //}

            //Usa la librería System.Collections.Generic;
            List<int> Valores = new List<int>();
            Valores.Add(5);
            Valores.Add(6);
            Valores.Add(9);
            Valores.Add(8);
            Valores.Add(1);
            Valores.Add(6);
            Valores.Add(10);
            Valores.Remove(6);
            Valores.RemoveAt(3);
            Valores.Insert(3, 7);
            for (int i = 0; i < Valores.Count; i++)
            {
                Console.WriteLine(Valores[i]);
            }
            Console.WriteLine();

            //Pruebas Metodos Propiedades
            Console.WriteLine(Valores.Count);
        }
    }
}
