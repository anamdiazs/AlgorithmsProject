using System;

namespace Ejercicio14Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Ingresa la cantidad de filas de la matriz:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de columnas de la matriz:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] Matriz = new int[A, B];
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write("*" + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
