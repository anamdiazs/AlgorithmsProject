using System;

namespace AOrdenacionSeleccion
{
    class Program
    {
        static int[] ArregloNumeros = new int[7];

        static void Main(string[] args)
        {
            int auxiliar = 0;
            llenaArreglo();                                     //Llena el arreglo con números manualmente
            muestraArreglo();                                   //Muestra el arreglo sin ordenar
            int iLimite = ArregloNumeros.Length-1;              //El índice Límite debe ser igual a la longitud del arreglo menos 1

            do {                                                        //Lo repite hasta que iLimite sea 0, entonces ahí con 0 ya no lo hace.
                int iMax = encuentraIndiceMaximo(iLimite);          //Encuentra el índice del valor máximo en un arreglo comparando desde el índice 0 hasta el índice iLimite
                auxiliar = ArregloNumeros[iLimite];                 //Guarda el valor de Ilimite en auxiliar
                ArregloNumeros[iLimite] = ArregloNumeros[iMax];     //Mete el Valor de IMax en el Ilimite
                ArregloNumeros[iMax] = auxiliar;                    //Mete el Valor de auxiliar en IMax
                iLimite--;                                          //Disminuye el valor del límite en 1
            } while (iLimite > 0);
            muestraArreglo();                                   //Muestra el arreglo ordenado
        }

        static void llenaArreglo()
        {
            ArregloNumeros[0] = 7;
            ArregloNumeros[1] = 1;
            ArregloNumeros[2] = 5;
            ArregloNumeros[3] = 4;
            ArregloNumeros[4] = 3;
            ArregloNumeros[5] = 6;
            ArregloNumeros[6] = 9;
        }

        static void muestraArreglo()
        {
            for (int i = 0; i < ArregloNumeros.Length; i++)
            {
                Console.Write(ArregloNumeros[i] + "     ");
            }
            Console.WriteLine();
        }

        static int encuentraIndiceMaximo(int Limite)
        {
            int indiceMaximo = 0;
            for(int i = 0; i<= Limite; i++)
            {
                if (ArregloNumeros[i] > ArregloNumeros[indiceMaximo])
                {
                    indiceMaximo = i;
                }
            }
            return indiceMaximo;
        }
    }
}
