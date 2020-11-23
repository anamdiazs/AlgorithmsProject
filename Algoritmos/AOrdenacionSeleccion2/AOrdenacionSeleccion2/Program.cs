using System;
using System.Collections.Generic;

namespace AOrdenacionSeleccion2
{
    class Program
    {
        static List<int> listanumeros = new List<int>();

        static void Main(string[] args)
        {
            int auxiliar = 0;
            llenaLista();                                     //Llena el arreglo con números manualmente
            muestraLista();                                   //Muestra el arreglo sin ordenar
            int iLimite = listanumeros.Count - 1;              //El índice Límite debe ser igual a la longitud del arreglo menos 1

            do
            {                                                        //Lo repite hasta que iLimite sea 0, entonces ahí con 0 ya no lo hace.
                int iMax = encuentraIndiceMaximo(iLimite);          //Encuentra el índice del valor máximo en un arreglo comparando desde el índice 0 hasta el índice iLimite
                auxiliar = listanumeros[iLimite];                 //Guarda el valor de Ilimite en auxiliar
                listanumeros[iLimite] = listanumeros[iMax];     //Mete el Valor de IMax en el Ilimite
                listanumeros[iMax] = auxiliar;                    //Mete el Valor de auxiliar en IMax
                iLimite--;                                          //Disminuye el valor del límite en 1
            } while (iLimite > 0);
            muestraLista();                                   //Muestra el arreglo ordenado
        }

        static void llenaLista()
        {
            listanumeros.Add(9);
            listanumeros.Add(7);
            listanumeros.Add(6);
            listanumeros.Add(5);
            listanumeros.Add(4);
            listanumeros.Add(3);
            listanumeros.Add(1);
        }

        static void muestraLista()
        {
            for (int i = 0; i < listanumeros.Count; i++)
            {
                Console.Write(listanumeros[i] + "     ");
            }
            Console.WriteLine();
        }

        static int encuentraIndiceMaximo(int Limite)
        {
            int indiceMaximo = 0;
            for (int i = 0; i <= Limite; i++)
            {
                if (listanumeros[i] > listanumeros[indiceMaximo])
                {
                    indiceMaximo = i;
                }
            }
            return indiceMaximo;
        }
    }
}
