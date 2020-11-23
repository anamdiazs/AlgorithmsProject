using System;
using System.Xml.Schema;

namespace Ejercicio8Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arreglo = new String[5];
            arreglo[0] = "2";
            arreglo[2] = "a";
            arreglo[4] = "EQ";
            int elemVacios = 0;
            int elemAsignados;

            for(int i = 0; i<arreglo.Length; i++)
            {
                if(arreglo[i] == null)
                {
                    elemVacios++;
                }
            }
            elemAsignados = arreglo.Length - elemVacios;
            Console.WriteLine(elemAsignados);
        }
    }
}
