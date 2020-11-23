using System;

namespace AOrdenacionQuickSort
{
    class Program
    {
        static int[] arr = new int[0];
        static void Main(string[] args)
        {
            llenadoArreglo(10);
            Console.WriteLine("Primer arreglo generado: ");
            MostrarNumeros();
            QuickSort(arr, 0, arr.Length);
            Console.WriteLine("Arreglo modificado con el QuickSort");
            MostrarNumeros();
        }

        static void llenadoArreglo(int N)
        {
            Array.Resize(ref arr, N);

            Random num = new Random();

            for (int i = 0; i < N; i++)
            {
                int Numero = num.Next(100);
                arr[i] = Numero;
            }
        }
        public static int[] QuickSort(int[] arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivote = Particion(arr, inicio, fin);
                QuickSort(arr, inicio, pivote);
                QuickSort(arr, pivote + 1, fin);
            }
            return arr;
        }
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int Particion(int[] arr, int inicio, int fin)
        {
            int pivote = arr[inicio];
            int cambioIndice = inicio;
            for (int i = inicio + 1; i < fin; i++)
            {
                if (arr[i] < pivote)
                {
                    cambioIndice++;
                    Swap(arr, i, cambioIndice);
                }
            }
            Swap(arr, inicio, cambioIndice);
            return cambioIndice;
        }

        static void MostrarNumeros()
        {
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("-" + arr[j] + "-");
            }
            Console.WriteLine();
        }
    }
}
