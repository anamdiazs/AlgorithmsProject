using System;

namespace Ejercicio1Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[10];

            for(int i=0; i<Numeros.Length; i++)
            {
                Numeros[i] = i*2;
            }

            //Imprimir
            for (int i=0; i<Numeros.Length; i++)
            {
                Console.WriteLine(i+"->"+Numeros[i]);
            }
        }
    }
}
