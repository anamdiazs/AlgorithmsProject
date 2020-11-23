using System;

namespace ArreglosIrregulares2
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            Console.WriteLine("Ingresa el número de filas de la matriz:");
            filas = int.Parse(Console.ReadLine());

            int[][] arreglo = new int[filas][];
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Ingresa el número de columnas de la fila " + (i+1) + ":");
                columnas = int.Parse(Console.ReadLine());
                arreglo[i] = new int[columnas];
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    Console.Write("*    ");
                }
                Console.WriteLine();
            }
        }
    }
}
