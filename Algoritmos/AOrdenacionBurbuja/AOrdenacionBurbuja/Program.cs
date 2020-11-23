using System;

namespace AOrdenacionBurbuja
{
    //Algoritmo de Ordenación en Burbuja
    class Program
    {

        static int[] ArregloNumeros = new int[7];
        static void Main(string[] args)
        {
            //Ordena usando el orden de llenaArreglo (Original)
            llenaArreglo();
            muestraArreglo();
            int Aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;

            for(int j = 0; j<ArregloNumeros.Length-1; j++) { 
                for(int i = 0; i<ArregloNumeros.Length-1; i++)
                {
                    if (ArregloNumeros[i] > ArregloNumeros[i + 1])
                    {
                        Aux = ArregloNumeros[i];
                        ArregloNumeros[i] = ArregloNumeros[i + 1];
                        ArregloNumeros[i + 1] = Aux;
                        totalIntercambios++;
                        totalComparaciones++;
                    }
                    else 
                    {
                        totalComparaciones++;
                    }
                }
                Console.WriteLine(".......................");
                muestraArreglo();
            }
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            //Ordena usando el orden de llenaArreglo2 (Al revés)
            llenaArreglo2();
            muestraArreglo();
            int Aux2 = 0;
            int totalComparaciones2 = 0;
            int totalIntercambios2 = 0;

            for (int j = 0; j < ArregloNumeros.Length - 1; j++)
            {
                for (int i = 0; i < ArregloNumeros.Length - 1; i++)
                {
                    if (ArregloNumeros[i] > ArregloNumeros[i + 1])
                    {
                        Aux2 = ArregloNumeros[i];
                        ArregloNumeros[i] = ArregloNumeros[i + 1];
                        ArregloNumeros[i + 1] = Aux2;
                        totalIntercambios2++;
                        totalComparaciones2++;
                    }
                    else
                    {
                        totalComparaciones2++;
                    }
                }
                Console.WriteLine(".......................");
                muestraArreglo();
            }
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones2);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios2);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            //Ordena usando el orden de llenaArreglo3 (Ordenados de Mayor a Menor (Peor Caso))
            llenaArreglo3();
            muestraArreglo();
            int Aux3 = 0;
            int totalComparaciones3 = 0;
            int totalIntercambios3 = 0;

            for (int j = 0; j < ArregloNumeros.Length - 1; j++)
            {
                for (int i = 0; i < ArregloNumeros.Length - 1; i++)
                {
                    if (ArregloNumeros[i] > ArregloNumeros[i + 1])
                    {
                        Aux3 = ArregloNumeros[i];
                        ArregloNumeros[i] = ArregloNumeros[i + 1];
                        ArregloNumeros[i + 1] = Aux3;
                        totalIntercambios3++;
                        totalComparaciones3++;
                    }
                    else
                    {
                        totalComparaciones3++;
                    }
                }
                Console.WriteLine(".......................");
                muestraArreglo();
            }
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones3);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios3);
        }

        static void llenaArreglo() 
        {
            ArregloNumeros[0] = 4;
            ArregloNumeros[1] = 7;
            ArregloNumeros[2] = 1;
            ArregloNumeros[3] = 8;
            ArregloNumeros[4] = 3;
            ArregloNumeros[5] = 9;
            ArregloNumeros[6] = 2;
        }

        static void llenaArreglo2()
        {
            ArregloNumeros[6] = 4;
            ArregloNumeros[5] = 7;
            ArregloNumeros[4] = 1;
            ArregloNumeros[3] = 8;
            ArregloNumeros[2] = 3;
            ArregloNumeros[1] = 9;
            ArregloNumeros[0] = 2;
        }

        static void llenaArreglo3()
        {
            ArregloNumeros[6] = 1;
            ArregloNumeros[5] = 2;
            ArregloNumeros[4] = 3;
            ArregloNumeros[3] = 4;
            ArregloNumeros[2] = 7;
            ArregloNumeros[1] = 8;
            ArregloNumeros[0] = 9;
        }

        static void muestraArreglo() 
        {
            for (int i=0; i<ArregloNumeros.Length; i++) 
            {
                Console.WriteLine(ArregloNumeros[i]);
            }
        }

    }
}
