using System;

//Este algoritmo binariza imagenes usando un umbral
namespace AlgoritmoBinarizacion
{
    class Program
    {
        static int[,] imagen = new int[5, 5];
        static int[,] ImagenB = new int[5, 5];

        static void LlenaMatriz()
        {
            imagen[0, 0] = 10;
            imagen[0, 1] = 10;
            imagen[0, 2] = 10;
            imagen[0, 3] = 10;
            imagen[0, 4] = 10;
            imagen[1, 0] = 10;
            imagen[1, 1] = 10;
            imagen[1, 2] = 10;
            imagen[1, 3] = 10;
            imagen[1, 4] = 10;
            imagen[2, 0] = 10;
            imagen[2, 1] = 10;
            imagen[2, 2] = 10;
            imagen[2, 3] = 10;
            imagen[2, 4] = 10;
            imagen[3, 0] = 10;
            imagen[3, 1] = 10;
            imagen[3, 2] = 10;
            imagen[3, 3] = 10;
            imagen[3, 4] = 10;
            imagen[4, 0] = 10;
            imagen[4, 1] = 10;
            imagen[4, 2] = 10;
            imagen[4, 3] = 10;
            imagen[4, 4] = 10;
        }

        static void MuestraArreglo(int[,] Imagen)
        {
            for(int f = 0; f<5; f++)
            {
                for(int c=0; c<5; c++)
                {
                    Console.Write(Imagen[f, c] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Binariza(int[,] Imagen, int umbral) 
        { 
            for(int f = 0; f<5; f++)
            {
                for(int c = 0; c<5; c++)
                {
                    if (imagen[f, c] > umbral)
                    {
                        ImagenB[f, c] = 1;
                    }
                    else
                    {
                        ImagenB[f, c] = 0;
                    }
                }
            }        
        }

        static void Main(string[] args)
        {
            //LlenaMatriz();
            GenerarNumeros(5);
            MuestraArreglo(imagen);
            Binariza(imagen, 50);
            Console.WriteLine();
            MuestraArreglo(ImagenB);
        }

        static void GenerarNumeros(int n)
        {
             //ResizeArray(imagen, n, n);
            Random Num = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) {
                    int Numero = Num.Next(100);     //Genera números aleatorios del 0 al parámetro.
                    imagen[i, j] = Numero;
                }
            }
        }
        /*static T[,] ResizeArray<T>(T[,] original, int filas, int cols)
        {
            var newArray = new T[filas, cols];
            int minfilas = Math.Min(filas, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minfilas; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }*/
    }
}
