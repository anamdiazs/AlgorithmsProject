using System;

namespace Ejercicio12Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Filas=Vendedores, Columnas=Zonas
            int[,] Arreglo = new int[3, 4];
            Arreglo[0, 0] = 1;
            Arreglo[0, 1] = 2;
            Arreglo[0, 2] = 3;
            Arreglo[0, 3] = 4;
            Arreglo[1, 0] = 9;
            Arreglo[1, 1] = 10;
            Arreglo[1, 2] = 12;
            Arreglo[1, 3] = 11;
            Arreglo[2, 0] = 8;
            Arreglo[2, 1] = 7;
            Arreglo[2, 2] = 6;
            Arreglo[2, 3] = 5;
            //Zona que más computadoras vendió
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            for (int i = 0; i < Arreglo.GetLength(0); i++)
            {
                a1 += Arreglo[i, 0];
                a2 += Arreglo[i, 1];
                a3 += Arreglo[i, 2];
                a4 += Arreglo[i, 3];
            }
            if (a1 > a2)
            {
                Console.WriteLine("La zona que más vendió fue la zona 1. Total: " + a1);
                for (int i = 0; i < Arreglo.GetLength(0); i++)
                {
                    Console.WriteLine(Arreglo[i, 0]);
                }
            } else
            {
                if (a2 > a3)
                {
                    Console.WriteLine("La zona que más vendió fue la zona 2. Total: " + a2);
                    for (int i = 0; i < Arreglo.GetLength(0); i++)
                    {
                        Console.WriteLine(Arreglo[i, 1]);
                    }
                }
                else
                {
                    if (a3 > a4)
                    {
                        Console.WriteLine("La zona que más vendió fue la zona 3. Total: " + a3);
                        for (int i = 0; i < Arreglo.GetLength(0); i++)
                        {
                            Console.WriteLine(Arreglo[i, 2]);
                        }
                    } else
                    {
                        Console.WriteLine("La zona que más vendió fue la zona 4. Total: " + a4);
                        for (int i = 0; i < Arreglo.GetLength(0); i++)
                        {
                            Console.WriteLine(Arreglo[i, 3]);
                        }
                    }
                }
            }
            //Vendedor que menos computadoras vendió
            Console.WriteLine();
            a1 = 0;
            a2 = 0;
            a3 = 0;
            for (int i = 0; i < Arreglo.GetLength(1); i++)
            {
                a1 += Arreglo[0, i];
                a2 += Arreglo[1, i];
                a3 += Arreglo[2, i];
            }
            if (a1 < a2)
            {
                Console.WriteLine("El vendedor que menos vendió fue el vendedor 1. Total: " + a1);
                for (int i = 0; i < Arreglo.GetLength(1); i++)
                {
                    Console.Write(Arreglo[0, i] + "     ");
                }
            } else
            {
                if (a2 < a3)
                {
                    Console.WriteLine("El vendedor que menos vendió fue el vendedor 2. Total: " + a2);
                    for (int i = 0; i < Arreglo.GetLength(1); i++)
                    {
                        Console.Write(Arreglo[1, i] + "     ");
                    }
                }
                else
                {
                    Console.WriteLine("El vendedor que menos vendió fue el vendedor 3. Total: " + a3);
                    for (int i = 0; i < Arreglo.GetLength(1); i++)
                    {
                        Console.Write(Arreglo[2, i] + "     ");
                    }
                }
            }
            Console.WriteLine();
            //Cantidad de computadoras vendidas por todos los vendedores en todas las zonas
            Console.WriteLine();
            a4 = a1 + a2 + a3;
            Console.WriteLine("La cantidad de computadoras vendidas por todos los vendedores en todas las zonas es de: " + a4);
            for (int i = 0; i<Arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < Arreglo.GetLength(1); j++)
                {
                    Console.Write(Arreglo[i, j] + "     ");
                }
                Console.WriteLine();
            }
        }
    }
}
