using System;
using System.Globalization;

namespace ArreglosIrregulares3
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            String nombre = null;
            Console.WriteLine("Ingresa el número de padres de familia:");
            filas = int.Parse(Console.ReadLine());

            String[][] arreglo = new String[filas][];
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Ingresa el número de hijos del padre número " + (i + 1) + ":");
                columnas = int.Parse(Console.ReadLine());
                arreglo[i] = new String[columnas];
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    Console.WriteLine("Ingresa el nombre del hijo número " + (j + 1) + ":");
                    nombre = Console.ReadLine();
                    arreglo[i][j] = nombre;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                Console.Write("Hijos del Padre " + (i+1) + ":       ");
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    Console.Write(arreglo[i][j] + ",       ");
                }
                Console.WriteLine();
            }
        }
    }
}
