using System;

namespace Ejercicio6Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglo = new int[2,3];
            int tam = 0;

            for(int i = 0; i<2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tam++;
                }
            }
        }
    }
}
