using System;

namespace Ejercicio10Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            int[,] arr3 = new int[2, 3];

            for(int i = 0; i<arr1.Length; i++)
            {
                Console.WriteLine("Ingresa el valor " + i+1 + " del primer arreglo:");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Ingresa el valor " + i+1 + " del segundo arreglo:");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr3.GetLength(1); i++)
            {
                arr3[0, i] = arr1[i];
                arr3[1, i] = arr2[i];
            }
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i,j] + "     ");
                }
                Console.WriteLine();
            }
        }
    }
}
