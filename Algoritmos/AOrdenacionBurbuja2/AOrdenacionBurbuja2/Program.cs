using System;
using System.Collections.Generic;

namespace AOrdenacionBurbuja2
{
    class Program
    {
        static List<int> listaNumeros = new List<int>();
        static void Main(string[] args)
        {
            //Ordena usando el orden de llenaArreglo (Original)
            listaNumeros.Clear();
            llenalista();
            muestralista();
            int Aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;

            for (int j = 0; j < listaNumeros.Count - 1; j++)
            {
                for (int i = 0; i < listaNumeros.Count - 1; i++)
                {
                    if (listaNumeros[i] > listaNumeros[i + 1])
                    {
                        Aux = listaNumeros[i];
                        listaNumeros[i] = listaNumeros[i + 1];
                        listaNumeros[i + 1] = Aux;
                        totalIntercambios++;
                        totalComparaciones++;
                    }
                    else
                    {
                        totalComparaciones++;
                    }
                }
                Console.WriteLine(".......................");
                muestralista();
            }
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            //Ordena usando el orden de llenaArreglo2 (Al revés)
            listaNumeros.Clear();
            llenalista2();
            muestralista();
            int Aux2 = 0;
            int totalComparaciones2 = 0;
            int totalIntercambios2 = 0;

            for (int j = 0; j < listaNumeros.Count - 1; j++)
            {
                for (int i = 0; i < listaNumeros.Count - 1; i++)
                {
                    if (listaNumeros[i] > listaNumeros[i + 1])
                    {
                        Aux2 = listaNumeros[i];
                        listaNumeros[i] = listaNumeros[i + 1];
                        listaNumeros[i + 1] = Aux2;
                        totalIntercambios2++;
                        totalComparaciones2++;
                    }
                    else
                    {
                        totalComparaciones2++;
                    }
                }
                Console.WriteLine(".......................");
                muestralista();
            }
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones2);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios2);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            //Ordena usando el orden de llenaArreglo3 (Ordenados de Mayor a Menor (Peor Caso))
            listaNumeros.Clear();
            llenalista3();
            muestralista();
            int Aux3 = 0;
            int totalComparaciones3 = 0;
            int totalIntercambios3 = 0;

            for (int j = 0; j < listaNumeros.Count - 1; j++)
            {
                for (int i = 0; i < listaNumeros.Count - 1; i++)
                {
                    if (listaNumeros[i] > listaNumeros[i + 1])
                    {
                        Aux3 = listaNumeros[i];
                        listaNumeros[i] = listaNumeros[i + 1];
                        listaNumeros[i + 1] = Aux3;
                        totalIntercambios3++;
                        totalComparaciones3++;
                    }
                    else
                    {
                        totalComparaciones3++;
                    }
                }
                Console.WriteLine(".......................");
                muestralista();
            }
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones3);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios3);
        }

        static void llenalista()
        {
            listaNumeros.Add(4);
            listaNumeros.Add(7);
            listaNumeros.Add(1);
            listaNumeros.Add(8);
            listaNumeros.Add(3);
            listaNumeros.Add(9);
            listaNumeros.Add(2);
        }

        static void llenalista2()
        {
            listaNumeros.Add(2);
            listaNumeros.Add(9);
            listaNumeros.Add(3);
            listaNumeros.Add(8);
            listaNumeros.Add(1);
            listaNumeros.Add(7);
            listaNumeros.Add(4);
        }

        static void llenalista3()
        {
            listaNumeros.Add(9);
            listaNumeros.Add(8);
            listaNumeros.Add(7);
            listaNumeros.Add(4);
            listaNumeros.Add(3);
            listaNumeros.Add(2);
            listaNumeros.Add(1);
        }

        static void muestralista()
        {
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }
        }
    }
}
