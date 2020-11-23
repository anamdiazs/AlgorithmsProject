using System;

namespace Ejercicio5Estructuras
{
    class Program
    {
        public struct Directorio
        {
            public String Nombre;
            public long Telefono;
            public int Extension;
            public String Horario;
            public String Dias;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE EL NÚMERO DE ENTRADAS");
            int n = int.Parse(Console.ReadLine());
            Directorio[] Contactos = new Directorio[n];
            //Insertar
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingresa el nombre");
                Contactos[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el telefono");
                Contactos[i].Telefono = long.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la extension");
                Contactos[i].Extension = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el horario");
                Contactos[i].Horario = Console.ReadLine();
                Console.WriteLine("Ingresa los dias");
                Contactos[i].Dias = Console.ReadLine();
            }

            //Mostrar

            for (int i = 0; i < n; i++)
            {
                Console.Write(Contactos[i].Nombre + "______");
                Console.Write(Contactos[i].Telefono + "______");
                Console.Write(Contactos[i].Extension + "______");
                Console.Write(Contactos[i].Horario + "______");
                Console.Write(Contactos[i].Dias + "______");
                Console.WriteLine();
            }

            //Buscar
            int Respuesta = 1;
            do {
                Console.WriteLine("Valor a Buscar:");
                String ValorB = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    if (ValorB == Contactos[i].Nombre)
                    {
                        Console.Write(Contactos[i].Nombre + "______");
                        Console.Write(Contactos[i].Telefono + "______");
                        Console.Write(Contactos[i].Extension + "______");
                        Console.Write(Contactos[i].Horario + "______");
                        Console.Write(Contactos[i].Dias + "______");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Deseas hacer otra búsqueda? 1=si 0=no");
                Respuesta = int.Parse(Console.ReadLine());
            } while (Respuesta == 1);
        }
    }
}
