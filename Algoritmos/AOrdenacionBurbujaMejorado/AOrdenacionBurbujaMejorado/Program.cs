using System;

namespace AOrdenacionBurbujaMejorado
{
    class Program
    {
        static int[] ArregloNumeros = new int[7];
        static void Main(string[] args)
        {
            llenaArreglo();
            muestraArreglo();
            int Aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;
            int intercambios = 0;

            do
            {
                intercambios = 0;
                for (int i = 0; i < ArregloNumeros.Length - 1; i++)
                {
                    if (ArregloNumeros[i] > ArregloNumeros[i + 1])
                    {
                        Aux = ArregloNumeros[i];
                        ArregloNumeros[i] = ArregloNumeros[i + 1];
                        ArregloNumeros[i + 1] = Aux;
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
                //muestraArreglo(); //Por cada iteración
            } while (intercambios != 0) ;
            Console.WriteLine(".....................");
            muestraArreglo();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();
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

        static void muestraArreglo()
        {
            for (int i = 0; i < ArregloNumeros.Length; i++)
            {
                Console.WriteLine(ArregloNumeros[i]);
            }
        }
    }
}
