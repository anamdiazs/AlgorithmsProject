using System;

namespace AOrdenacionMonticulos
{
    class Program
    {
        static int[] valores = new int[0];

        public static void Main()
        {
            GenerarNumeros(10);
            MostrarNumeros();
            heapSort(valores, valores.Length);
            MostrarNumeros();
        }
        static void heapSort(int[] valores, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(valores, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = valores[0];
                valores[0] = valores[i];
                valores[i] = temp;
                heapify(valores, i, 0);
            }
        }
        static void heapify(int[] valores, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && valores[left] > valores[largest])
                largest = left;
            if (right < n && valores[right] > valores[largest])
                largest = right;
            if (largest != i)
            {
                int swap = valores[i];
                valores[i] = valores[largest];
                valores[largest] = swap;
                heapify(valores, n, largest);
            }
        }

        static void GenerarNumeros(int n)
        {
            Array.Resize(ref valores, n);
            Random Num = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                int Numero = Num.Next(100);     
                valores[i] = Numero;
            }
        }

        static void MostrarNumeros()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write(valores[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
