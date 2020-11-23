using System;

namespace Ejercicio7Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglo = new int[4,3];

            int rank = 0;
            Boolean o = true;

            while (o)
            {
                try
                {
                    arreglo.GetLength(rank++);
                }

                catch
                {
                    rank--;
                    o = false;
                }             
            }
            Console.WriteLine(rank);
        }
    }
}
