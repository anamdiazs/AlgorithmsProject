using System;

namespace ArreglosIrregulares4
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int contador = 1;
            Console.WriteLine("Ingresa el número de días de lecturas de velocidad:");
            filas = int.Parse(Console.ReadLine());

            int[][] arreglo = new int[filas][];
            for (int i = 0; i < filas; i++)
            {
                arreglo[i] = new int[i+1];
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    arreglo[i][j] = contador;
                    contador++;
                }
            }
            //Imprimir
            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    Console.Write(arreglo[i][j] + "     ");
                }
                Console.WriteLine();
            }
        }
    }
}
