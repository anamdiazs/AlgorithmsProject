using System;

namespace Ejercicio4Estructuras
{
    class Program
    {
        public struct Persona
        {
            public String nombre;
            public int diaNacimiento;
            public int mesNacimiento;
            public int anoNacimiento;
        }

        static void Main(string[] args)
        {
            Boolean o = true;
            int mesImprimir = 0;
            Persona[] personas = new Persona[8];
            for(int i=0; i<8; i++)
            {
                Console.WriteLine("Ingresa el nombre de la persona " + (i+1) + ":");
                personas[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el día de nacimiento de la persona " + (i+1) + ":");
                personas[i].diaNacimiento = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el mes (número) de nacimiento de la persona " + (i + 1) + ":");
                personas[i].mesNacimiento = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el año de nacimiento de la persona " + (i + 1) + ":");
                personas[i].anoNacimiento = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingresa el número de un mes:");
                mesImprimir = int.Parse(Console.ReadLine());
                Console.WriteLine();                
                switch (mesImprimir)
                {
                    case 1:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 10:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 11:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 12:
                        Console.WriteLine("Los datos de las personas que cumplen años el mes " + mesImprimir + " son:");
                        Console.WriteLine();
                        for (int i = 0; i < 8; i++)
                        {
                            if (personas[i].mesNacimiento == mesImprimir)
                            {
                                Console.WriteLine("Nombre: " + personas[i].nombre);
                                Console.WriteLine("Día de Nacimiento: " + personas[i].diaNacimiento);
                                Console.WriteLine("Mes de Nacimiento: " + personas[i].mesNacimiento);
                                Console.WriteLine("Año de Nacimiento: " + personas[i].anoNacimiento);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar la aplicación. Saliendo.");
                        o = false;
                        break;
                    default:
                        Console.WriteLine("Número no válido. Intenta con otro del 1 al 12 o pulsa 0 para salir.");
                        break;
                }
            } while (o);
        }
    }
}
