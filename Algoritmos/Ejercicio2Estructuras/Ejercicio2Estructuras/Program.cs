using System;

namespace Ejercicio2Estructuras
{
    class Program
    {
        public struct Empleado
        {
            public String nombre;
            public String sexo;
            public double sueldo;
        }

        static void Main(string[] args)
        {
            int totalempleados = 0;
            double sueldoM = 0;
            int indiceEmpSM = 0;
            Console.WriteLine("Ingrese el número de empleados:");
            totalempleados = int.Parse(Console.ReadLine());
            Empleado[] empleados = new Empleado[totalempleados];

            for(int i = 0; i<totalempleados; i++)
            {
                Console.WriteLine("Ingresa el nombre del empleado " + (i+1) + ":");
                empleados[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el sexo del empleado " + (i + 1) + ":");
                empleados[i].sexo = Console.ReadLine();
                Console.WriteLine("Ingresa el sueldo del empleado " + (i + 1) + ":");
                empleados[i].sueldo = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            sueldoM = empleados[0].sueldo;
            for(int i = 0; i<totalempleados; i++)
            {
                if (sueldoM < empleados[i].sueldo)
                {
                    sueldoM = empleados[i].sueldo;
                    indiceEmpSM = i;
                }
            }
            Console.WriteLine("Datos del empleado con el mayor sueldo:");
            Console.WriteLine("Nombre: " + empleados[indiceEmpSM].nombre);
            Console.WriteLine("Sexo: " + empleados[indiceEmpSM].sexo);
            Console.WriteLine("Sueldo: " + empleados[indiceEmpSM].sueldo);
        }
    }
}
