using System;

namespace Ejercicio9Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arreglo = new String[4];
            int elemVacios = 0;

            for(int i = 0; i<arreglo.Length; i++)
            {
                if(arreglo[i] == null)
                {
                    elemVacios++;
                }
            }
            if (elemVacios == arreglo.Length)
            {
                Console.WriteLine("El arreglo está vacío");
            } else
            {
                if (elemVacios == 0)
                {
                    Console.WriteLine("El arreglo está lleno");
                } else
                {
                    Console.WriteLine("El arreglo no está ni lleno ni vacío");
                }
            }
        }
    }
}
