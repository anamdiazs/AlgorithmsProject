using System;

namespace Ejercicio11Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[4, 3];
            A[0, 0] = 3;
            A[0, 1] = 6;
            A[0, 2] = 9;
            A[1, 0] = 12;
            A[1, 1] = 15;
            A[1, 2] = 18;
            A[2, 0] = 21;
            A[2, 1] = 24;
            A[2, 2] = 27;
            A[3, 0] = 30;
            A[3, 1] = 33;
            A[3, 2] = 36;
            int[,] Z = new int[4, 3];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Z[i, j] = A[A.GetLength(0)-1-i,A.GetLength(1)-1-j];
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = Z[i, j];
                }
            }
            //A) Imprimir 
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "       ");
                }
                Console.WriteLine();
            }
            //B) Ajustar Valores
            Console.WriteLine();
            int[] B = new int[12];
            int k = 0;
            for (int i = 0; i < Z.GetLength(0); i++)
            {
                for (int j = 0; j < Z.GetLength(1); j++)                   
                {
                    B[k] = A[A.GetLength(0)-1-i, A.GetLength(1)-1-j];
                    k++;
                }               
            }
            k = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    A[i, j] = B[k];
                    k++;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "       ");
                }
                Console.WriteLine();
            }
            //C) Ajustar Valores
            Console.WriteLine();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Z[i, j] = A[A.GetLength(0) - 1 - i, A.GetLength(1) - 1 - j];
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = Z[i, j];
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "       ");
                }
                Console.WriteLine();
            }
            //D) Obtener los valores mínimo, máximo, promedio, total de elementos, suma y producto.
            Console.WriteLine();
            k = A[0, 0];
            int l = k;
            int suma = 0;
            int total = 0;
            long producto = 1;
            Decimal promedio = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > k )
                    {
                        k = A[i, j];
                    }
                    if (A[i, j] < l)
                    {
                        l = A[i, j];
                    }
                    suma += A[i, j];
                    total++;
                    producto *= A[i, j];
                }
            }
            promedio = (Decimal) suma / (Decimal) total;
            Console.WriteLine("Valor Mínimo: " + l);
            Console.WriteLine("Valor Máximo: " + k);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Total de Elementos: " + total);
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Producto: " + producto);
        }
    }
}
