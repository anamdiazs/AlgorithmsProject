using System;

namespace Ejercicio1Estructuras
{
    class Program
    {
        public struct Persona
        {
            public String nombre;
            public String apellido;
            public int edad;
        }

        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Console.WriteLine("Ingresa el nombre de la persona:");
            p1.nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido de la persona:");
            p1.apellido = Console.ReadLine();
            Console.WriteLine("Ingresa la edad de la persona:");
            p1.edad = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(p1.nombre + ", " + p1.apellido + ", " + p1.edad);
        }
    }
}
