using System;

namespace AlgoritmoOrdenacionInsert
{
    class Program
    {
        static int[] ArregloNumeros = new int[5];
        static void Main(string[] args)
        {
            llenaArreglo();
            muestraArreglo();
            int aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;

            for (int clave = 1; clave < ArregloNumeros.Length; clave++)
            {
                int indice = clave;
                while(indice > 0) {                  
                    if(ArregloNumeros[indice] < ArregloNumeros[indice-1])
                    {
                        aux = ArregloNumeros[indice-1];
                        ArregloNumeros[indice-1] = ArregloNumeros[indice];
                        ArregloNumeros[indice] = aux;
                        totalIntercambios++;
                    }
                    indice--;
                    totalComparaciones++;
                }
                //Console.WriteLine(".......................");     //Ya se usa el mostrar números del método main
                //muestraArreglo(); //Por cada iteración
            }
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            muestraArreglo();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);
        }

        static void llenaArreglo()
        {
            ArregloNumeros[0] = 5;
            ArregloNumeros[1] = 2;
            ArregloNumeros[2] = 4;
            ArregloNumeros[3] = 1;
            ArregloNumeros[4] = 3;
            //ArregloNumeros[5] = 6;
            //ArregloNumeros[6] = 9;
        }

        static void muestraArreglo()
        {
            for (int i = 0; i < ArregloNumeros.Length; i++)
            {
                Console.Write(ArregloNumeros[i] + "     ");
            }
            Console.WriteLine();
        }
    }
}
