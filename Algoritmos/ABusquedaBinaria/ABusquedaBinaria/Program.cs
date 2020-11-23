using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABusquedaBinaria
{
    class Busqueda
    {
        static private int[] vector;
        public void Cargar()
        {
            Console.WriteLine("Busqueda Binaria");
            Console.WriteLine("Ingrese 10 Elementos");
            string linea;
            vector = new int[10];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }
        public void busqueda(int num)
        {
            int l = 0, h = vector.Length - 1;
            int m = 0;
            bool found = false;
            while (l <= h && found == false)
            {
                m = (l + h) / 2;
                if (vector[m] == num)
                    found = true;
                if (vector[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
            { Console.Write("\nEl elemento {0} no esta en el arreglo", num); }
            else
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, m + 1); }
        }
        public void Imprimir()
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
        static void Main(string[] args)
        {
            Busqueda pv = new Busqueda();
            GenerarNumeros(15);
            //pv.Cargar();
            pv.Imprimir();
            Console.WriteLine();
            QuickSort(vector, 0, vector.Length);
            pv.Imprimir();
            Console.Write("\n\nElemento a buscar: ");
            int num = int.Parse(Console.ReadLine());
            pv.busqueda(num);
            Console.ReadKey();
        }

        static void GenerarNumeros(int N)
        {
            Array.Resize(ref vector, N);

            Random num = new Random();

            for (int i = 0; i < N; i++)
            {
                int Numero = num.Next(100);
                vector[i] = Numero;
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
    }
}
