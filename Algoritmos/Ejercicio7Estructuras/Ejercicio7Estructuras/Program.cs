using System;

namespace Ejercicio7Estructuras
{
    class Program
    {
        public struct Archivo
        {
            public String Nombre;
            public long Tamano;
        }

        static void Main(string[] args)
        {          
            Boolean o = true;
            int i = 0;
            Archivo[] Archivos = new Archivo[0];
            do {
                Console.WriteLine("Menu: 1= Añadir datos de un nuevo fichero, 2= Mostrar los nombres de los ficheros, 3= Mostrar archivos de más de cierto tamaño, 4= Ver archivos ordenador por nombre, 5= Salir.");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        if (10 > Archivos.Length) 
                        {                           
                            int Resp;
                            do
                            {
                                Array.Resize(ref Archivos, Archivos.Length + 1);
                                Console.WriteLine("Dame el nombre del archivo");
                                Archivos[i].Nombre = Console.ReadLine();
                                Console.WriteLine("Dame el tamaño del archivo");
                                Archivos[i].Tamano = long.Parse(Console.ReadLine());
                                Console.WriteLine("Deseas ingresar otro elemento? 1=si, 0=no");
                                Resp = int.Parse(Console.ReadLine());
                                i++;
                            } while (Resp == 1 && Archivos.Length < 10);
                        }
                        else
                        {
                            Console.WriteLine("Se ha alcanzado el número máximo de archivos");
                        }
                        break;
                    case 2:
                        for (int j = 0; j < Archivos.Length; j++)
                        {
                            Console.WriteLine(Archivos[j].Nombre);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingresa el límite del tamaño del archivo");
                        int LimTam = int.Parse(Console.ReadLine());
                        for (int j = 0; j < Archivos.Length; j++)
                        {
                            if (Archivos[j].Tamano > LimTam)
                            {
                                Console.WriteLine(Archivos[j].Nombre);
                            }
                        }
                        break;
                    case 4:
                        Array.Sort(Archivos, (x,y) => x.Nombre.CompareTo(y.Nombre));
                        for (int j = 0; j < Archivos.Length; j++)
                        {
                            Console.WriteLine(Archivos[j].Nombre);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar la aplicación. Saliendo.");
                        o = false;
                        break;
                    default:
                        Console.WriteLine("Ese no es un número válido, intenta de nuevo.");
                        break;
                }
            } while (o);
        }
    }
}
