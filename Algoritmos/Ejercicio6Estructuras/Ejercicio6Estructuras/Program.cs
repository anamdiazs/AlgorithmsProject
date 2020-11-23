using System;

namespace Ejercicio6Estructuras
{
    class Program
    {
        public struct Persona
        {
            public String nombre;
            public String direccion;
            public long telefono;
            public int edad;
        }

        static void Main(string[] args)
        {
            Persona[] personas = new Persona[0];
            Boolean o = true;
            int i = 0;
            String comparar;
            int menu = 0;
            int edadM = 0;
            char inicial;
            do
            {                
                Console.WriteLine("Ingresa el nombre de la persona " + (i+1));
                comparar = Console.ReadLine();
                if (comparar != "") 
                {
                    Array.Resize(ref personas, personas.Length + 1);
                    personas[i].nombre = comparar;
                    Console.WriteLine("Ingresa la direccion de la persona " + (i+1));
                    personas[i].direccion = Console.ReadLine();
                    Console.WriteLine("Ingresa el telefono de la persona " + (i + 1));
                    personas[i].telefono = long.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la edad de la persona " + (i + 1));
                    personas[i].edad = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    o = false;
                }
            } while (o && personas.Length < 50);
            Console.WriteLine();
            o = true;
            do
            {
                Console.WriteLine("Menú: 1= Mostrar lista de todos los nombres, 2= Mostrar las personas de cierta edad, 3= Mostrar las personas que tengan cierta inicial, 4= Salir.");
                menu = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (menu)
                {
                    case 1:
                        for (int j=0; j<personas.Length; j++)
                        {
                            Console.WriteLine(personas[j].nombre);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Ingresa la edad de las personas a mostrar");
                        edadM = int.Parse(Console.ReadLine());
                        for (int j = 0; j < personas.Length; j++)                       
                        {
                            if (edadM == personas[j].edad)
                            {
                                Console.Write(personas[j].nombre + "_____");
                                Console.Write(personas[j].direccion + "_____");
                                Console.Write(personas[j].telefono + "_____");
                                Console.Write(personas[j].edad);
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Ingresa la inicial de los nombres:");
                        inicial = char.Parse(Console.ReadLine());
                        for (int j=0; j<personas.Length; j++)
                        {
                            if (personas[j].nombre.StartsWith(inicial))
                            {
                                Console.Write(personas[j].nombre + "_____");
                                Console.Write(personas[j].direccion + "_____");
                                Console.Write(personas[j].telefono + "_____");
                                Console.Write(personas[j].edad);
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar la aplicación. Saliendo.");
                        o = false;
                        break;
                    default:
                        Console.WriteLine("Ese no es un número válido. Intenta de nuevo");
                        break;
                }
            } while (o);
        }
    }
}
