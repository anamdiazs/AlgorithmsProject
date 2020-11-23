using System;

namespace Ejercicio4Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[10];

            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = i * 2;
            }

            int[] Copia = new int[10];

            for(int i = Numeros.Length; i>0; i--)
            {
                Copia[10-i] = Numeros[i-1];
            }

            for(int i = 0; i<Numeros.Length; i++)
            {
                Numeros[i] = Copia[i];
            }

            //Imprimir
            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine(i + "->" + Numeros[i]);
            }
        }
    }
}
