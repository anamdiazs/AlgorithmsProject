using System;

namespace Ejercicio13Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Arreglo = new int[100, 10];
            int A = 0;
            for(int i = 0; i< Arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < Arreglo.GetLength(1); j++)
                {
                    A += 2;
                    Arreglo[i, j] = A;
                }
            }
            for (int i = 0; i < Arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < Arreglo.GetLength(1); j++)
                {
                    Console.Write(Arreglo[i, j] + "     ");
                }
                Console.WriteLine();
            }
        }
    }
}
