using System;

namespace ABusquedaLineal
{
    class Program
    {
        static int[] valores = new int[0];

        static void Main(string[] args)
        {
            GenerarNumeros(10);
            MostrarNumeros();

            int Comparaciones = 0;
            int Indice = -1;
            int ElementoB = 28;
            int n = valores.Length;

            Console.WriteLine();
            Console.WriteLine("Ingresa el número a buscar: ");
            ElementoB = int.Parse(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                Comparaciones++;
                if(ElementoB == valores[i])
                {
                    Indice = i;
                    break;
                }
            }
            Console.WriteLine("El Indice es: " + Indice);
            Console.WriteLine("Comparaciones: " + Comparaciones);
        }

        static void GenerarNumeros(int n)
        {
            Array.Resize(ref valores, n);
            Random Num = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                int Numero = Num.Next(100);     //Genera números aleatorios del 0 al parámetro.
                valores[i] = Numero;
            }
        }

        static void MostrarNumeros()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
