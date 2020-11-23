using System;

namespace Ejercicio8Estructuras
{
    class Program
    {
        public struct Vehiculo
        {
            public String marca;
            public String modelo;
            public String clase;
            public String color;
            public int year;
            public String placa;
            public String num_motor;
            public String chasis;
        }

        public struct Propietario
        {
            public String nombre;
            public String apellido;
            public String direccion;
            public Vehiculo[] carromio;
        }

        static void Main(string[] args)
        {
            Propietario[] propietarios = new Propietario[0];
            int i = 0;
            int o = 1;
            int o2 = 1;
            String nombreB;
            int resp = 1;
            do
            {
                Array.Resize(ref propietarios, propietarios.Length+1);
                Console.WriteLine("Ingresa el nombre del propietario:");
                propietarios[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido del propietario:");
                propietarios[i].apellido = Console.ReadLine();
                Console.WriteLine("Ingresa la dirección del propietario:");
                propietarios[i].direccion = Console.ReadLine();
                Console.WriteLine("Ingresa los datos del vehiculo del propietario:");
                propietarios[i].carromio = new Vehiculo[0];
                int j = 0;
                do
                {
                    Array.Resize(ref propietarios[i].carromio, propietarios[i].carromio.Length + 1);
                    Console.WriteLine("Ingresa la marca del vehiculo:");
                    propietarios[i].carromio[j].marca = Console.ReadLine();
                    Console.WriteLine("Ingresa el modelo del vehiculo:");
                    propietarios[i].carromio[j].modelo = Console.ReadLine();
                    Console.WriteLine("Ingresa la clase del vehiculo:");
                    propietarios[i].carromio[j].clase = Console.ReadLine();
                    Console.WriteLine("Ingresa el color del vehiculo:");
                    propietarios[i].carromio[j].color = Console.ReadLine();
                    Console.WriteLine("Ingresa el año del vehiculo:");
                    propietarios[i].carromio[j].year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la placa del vehiculo:");
                    propietarios[i].carromio[j].placa = Console.ReadLine();
                    Console.WriteLine("Ingresa el número del motor del vehiculo:");
                    propietarios[i].carromio[j].num_motor = Console.ReadLine();
                    Console.WriteLine("Ingresa el chasis del vehiculo:");
                    propietarios[i].carromio[j].chasis = Console.ReadLine();
                    j++;
                    Console.WriteLine("¿Quieres agregar otro vehiculo? 1=si, 2=no");
                    o2 = int.Parse(Console.ReadLine());
                } while (o2 == 1);
                i++;
                Console.WriteLine();
                Console.WriteLine("¿Quieres agregar otro propietario? 1=si, 2=no");
                o = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (o == 1);
            //Imprimir
            do {
                Console.WriteLine("Ingresa el nombre de un Propietario para mostrar sus datos:");
                nombreB = Console.ReadLine();
                for (int j = 0; j < propietarios.Length; j++)
                {
                    if (nombreB == propietarios[j].nombre)
                    {
                        Console.Write(propietarios[j].nombre + "____");
                        Console.Write(propietarios[j].apellido + "____");
                        Console.Write(propietarios[j].direccion);
                        Console.WriteLine();
                        for (int k = 0; k < propietarios[j].carromio.Length; k++)
                        {
                            Console.Write(propietarios[j].carromio[k].marca + "____");
                            Console.Write(propietarios[j].carromio[k].modelo + "____");
                            Console.Write(propietarios[j].carromio[k].clase + "____");
                            Console.Write(propietarios[j].carromio[k].color + "____");
                            Console.Write(propietarios[j].carromio[k].year + "____");
                            Console.Write(propietarios[j].carromio[k].placa + "____");
                            Console.Write(propietarios[j].carromio[k].num_motor + "____");
                            Console.Write(propietarios[j].carromio[k].chasis);
                            Console.WriteLine();
                        }
                        Console.WriteLine("----------------------------------------------------");
                    }
                }
                Console.WriteLine("¿Quieres buscar otro propietario? 1=Si, 2=Salir");
                resp = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (resp == 1);
        }
    }
}
