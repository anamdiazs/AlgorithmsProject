using System;
using System.Runtime.CompilerServices;

namespace FuncionesYMetodosFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean o = true;
            do {
                try {
                    int figura;
                    Console.WriteLine("Escoge el tipo de figura (1=Círculo, 2=Cuadrado, 3=Triángulo, 4=Rectángulo, 5=Pentágono, 6=Hexágono, 7=Salir):");
                    figura = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (figura)
                    {
                        case 1:
                            Circulo c1 = new Circulo();
                            c1.Datos();
                            break;
                        case 2:
                            Cuadrado cu1 = new Cuadrado();
                            cu1.Datos();
                            break;
                        case 3:
                            Triangulo t1 = new Triangulo();
                            t1.Datos();
                            break;
                        case 4:
                            Rectangulo r1 = new Rectangulo();
                            r1.Datos();
                            break;
                        case 5:
                            Pentagono p1 = new Pentagono();
                            p1.Datos();
                            break;
                        case 6:
                            Hexagono h1 = new Hexagono();
                            h1.Datos();
                            break;
                        case 7:
                            Console.WriteLine();
                            Console.WriteLine("Ejecución Finalizada.");
                            o = false;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Ese no es un número del menú, por favor vuelve a intentar.");
                            break;
                    }
                } catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Eso no es un número, por favor vuelve a intentar.");
                    Console.WriteLine();
                } catch (Exception e) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Un error del tipo: " + e + " ha ocurrido. Por favor vuelve a intentar.");
                    Console.WriteLine();
                }
            } while (o);
        }
    }
    abstract class Figura
    {
        public abstract void CalcularPerimetro();
        public abstract void CalcularArea();
        public abstract void Datos();
    }
    class Circulo : Figura
    {
        private double radio;
        public override void Datos()
        {
            Console.WriteLine("Ingresa el radio:");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine();
            CalcularPerimetro();
            CalcularArea();
            Console.WriteLine();
        }
        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perímetro es: " + (Math.PI * 2 * radio));
        }
        public override void CalcularArea()
        {
            Console.WriteLine("El área es: " + (Math.PI * radio * radio));
        }
    }
    class Cuadrado : Figura
    {
        private double lado;
        public override void Datos()
        {
            Console.WriteLine("Ingresa la medida del lado:");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine();
            CalcularPerimetro();
            CalcularArea();
            Console.WriteLine();
        }
        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perímetro es: " + (lado*4));
        }
        public override void CalcularArea()
        {
            Console.WriteLine("El área es: " + (lado*lado));
        }
    }
    class Triangulo : Figura
    {
        private double lado;
        private int tipo;
        private double lado2;
        private double lado3;
        private double altura;
        public override void Datos()
        {
            Boolean o = true;
            do
            {
                try
                {
                    Console.WriteLine("Escoge el triángulo (1=Equilátero, 2=Isósceles, 3=Escaleno):");
                    tipo = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (tipo)
                    {
                        case 1:
                            Console.WriteLine("Ingresa el valor de la altura:");
                            altura = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor del lado:");
                            lado = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            CalcularPerimetro();
                            CalcularArea();
                            Console.WriteLine();
                            o = false;
                            break;
                        case 2:
                            Console.WriteLine("Ingresa el valor de la altura (medida desde el lado diferente):");
                            altura = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor del lado que se repite:");
                            lado = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor del lado diferente:");
                            lado2 = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            CalcularPerimetro2();
                            CalcularArea2();
                            Console.WriteLine();
                            o = false;
                            break;
                        case 3:                           
                            Console.WriteLine("Ingresa el valor del 1er lado:");
                            lado = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor de la altura (medida desde el lado anterior):");
                            altura = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor del 2do lado:");
                            lado2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor del 3er lado:");
                            lado3 = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            CalcularPerimetro3();
                            CalcularArea3();
                            Console.WriteLine();
                            o = false;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Ese no es un número del menú, por favor vuelve a intentar.");
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Eso no es un número, por favor vuelve a intentar.");
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Un error del tipo: " + e + " ha ocurrido. Por favor vuelve a intentar.");
                    Console.WriteLine();
                }
            } while (o);
        }
        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perímetro es: " + (lado * 3));
        }
        public override void CalcularArea()
        {
            Console.WriteLine("El área es: " + ((lado * altura)/2));
        }
        public void CalcularPerimetro2()
        {
            Console.WriteLine("El perímetro es: " + (lado+lado+lado2));
        }
        public void CalcularArea2()
        {
            Console.WriteLine("El área es: " + ((lado2 * altura)/2 ));
        }
        public void CalcularPerimetro3()
        {
            Console.WriteLine("El perímetro es: " + (lado + lado2 + lado3));
        }
        public void CalcularArea3()
        {
            Console.WriteLine("El área es: " + ((lado * altura)/2));
        }
    }
    class Rectangulo : Figura
    {
        private double lado;
        private double lado2;
        public override void Datos()
        {
            Console.WriteLine("Ingresa la medida del 1er lado:");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del 2do lado:");
            lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            CalcularPerimetro();
            CalcularArea();
            Console.WriteLine();
        }
        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perímetro es: " + (lado+lado+lado2+lado2));
        }
        public override void CalcularArea()
        {
            Console.WriteLine("El área es: " + (lado * lado2));
        }
    }
    class Pentagono : Figura
    {
        private double lado;
        private double apotema;
        public override void Datos()
        {
            Console.WriteLine("Ingresa la medida del lado:");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del apotema (Centro de la figura al centro de un lado):");
            apotema = double.Parse(Console.ReadLine());
            Console.WriteLine();
            CalcularPerimetro();
            CalcularArea();
            Console.WriteLine();
        }
        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perímetro es: " + (lado*5));
        }
        public override void CalcularArea()
        {
            Console.WriteLine("El área es: " + ((lado*5*apotema)/2));
        }
    }
    class Hexagono : Figura
    {
        private double lado;
        private double apotema;
        public override void Datos()
        {
            Console.WriteLine("Ingresa la medida del lado:");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del apotema (Centro de la figura al centro de un lado):");
            apotema = double.Parse(Console.ReadLine());
            Console.WriteLine();
            CalcularPerimetro();
            CalcularArea();
            Console.WriteLine();
        }
        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perímetro es: " + (lado * 6));
        }
        public override void CalcularArea()
        {
            Console.WriteLine("El área es: " + ((lado * 6 * apotema) / 2));
        }
    }
}
