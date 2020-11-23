using System;

namespace Ejercicio2Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz = new int[3, 4];
            int valor;
            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingresa el valor de la Fila: " + i + "Columna: " + j);
                    valor = int.Parse(Console.ReadLine());
                    Matriz[i, j] = valor;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Matriz[i, j] + "      ");
                }
                Console.WriteLine();
            }
        }
    }
}
