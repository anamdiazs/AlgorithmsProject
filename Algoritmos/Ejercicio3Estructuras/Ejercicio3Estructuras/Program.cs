using System;
using System.Runtime.InteropServices.ComTypes;

namespace Ejercicio3Estructuras
{
    class Program
    {
        public struct Libro
        {
            public String titulo;
            public String autor;
            public long isbn;
            public double Precio;
            public int Cantidad;
            public String Editorial;
        }

        static void Main(string[] args)
        {
            int i = 0;
            Libro[] Libros = new Libro[0];
            int resp = 0;
            int cantidadt = 0;
            double valorti = 0;
            double valorlibros = 0;
            double promedio = 0;

            do
            {
                Array.Resize(ref Libros, i+1);
                Console.WriteLine("Ingresar el nombre del libro");
                Libros[i].titulo = Console.ReadLine();
                Console.WriteLine("Ingresar el nombre del autor");
                Libros[i].autor = Console.ReadLine();
                Console.WriteLine("Ingresar el ISBN del libro");
                Libros[i].isbn = long.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar el Precio");
                Libros[i].Precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar la cantidad");
                Libros[i].Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar la editorial");
                Libros[i].Editorial = Console.ReadLine();
                Console.WriteLine("Deseas agregar otro libro: 1=si 2=no");
                resp = int.Parse(Console.ReadLine());
                i++;
            } while (resp == 1);     
            
            for(int j= 0; j<Libros.Length; j++)
            {
                Console.Write(Libros[j].titulo + "----");
                Console.Write(Libros[j].autor + "----");
                Console.Write(Libros[j].isbn + "----");
                Console.Write(Libros[j].Precio + "----");
                Console.Write(Libros[j].Cantidad + "----");
                Console.Write(Libros[j].Editorial);
                Console.WriteLine();
                cantidadt += Libros[j].Cantidad;
                valorti += Libros[j].Precio * Libros[j].Cantidad;
                valorlibros += Libros[j].Precio;
            }
            Console.WriteLine("La cantidad total de libros es: " + cantidadt);
            Console.WriteLine("El valor total de inventario: " + valorti);
            Console.WriteLine("El promedio del precio de los libros es: " + (valorlibros/Libros.Length));
        }
    }
}
