using System;
using System.Collections.Generic;

namespace AOrdenacionBurbujaMejorado2
{
    class Program
    {
        static List<int> listaNumeros = new List<int>();
        static void Main(string[] args)
        {
            llenaLista();
            muestraLista();
            int Aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;
            int intercambios = 0;

            do
            {
                intercambios = 0;
                for (int i = 0; i < listaNumeros.Count - 1; i++)
                {
                    if (listaNumeros[i] > listaNumeros[i + 1])
                    {
                        Aux = listaNumeros[i];
                        listaNumeros[i] = listaNumeros[i + 1];
                        listaNumeros[i + 1] = Aux;
                        totalIntercambios++;
                        totalComparaciones++;
                        intercambios++;
                    }
                    else
                    {
                        totalComparaciones++;
                    }
                }
                //Console.WriteLine(".......................");
                //muestraLista(); //Por cada iteración
            } while (intercambios != 0);
            Console.WriteLine(".....................");
            muestraLista();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();
        }
        static void llenaLista()
        {
            listaNumeros.Add(4);
            listaNumeros.Add(7);
            listaNumeros.Add(1);
            listaNumeros.Add(8);
            listaNumeros.Add(3);
            listaNumeros.Add(9);
            listaNumeros.Add(2);
        }

        static void muestraLista()
        {
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }
        }
    }
}
