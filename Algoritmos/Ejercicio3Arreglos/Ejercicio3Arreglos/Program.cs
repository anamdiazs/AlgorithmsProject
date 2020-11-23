using System;

namespace Ejercicio3Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Inserte el tamaño de la Dx");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el tamaño de la Dy");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el tamaño de la Dz");
            z = int.Parse(Console.ReadLine());

            int[,,] Arreglo = new int[x, y, z];
        }
    }
}
