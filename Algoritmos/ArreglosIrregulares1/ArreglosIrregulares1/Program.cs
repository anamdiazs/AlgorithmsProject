using System;

namespace ArreglosIrregulares1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Irregulares Declaración con filas
            int[][] Salarios = new int[5][];
            //Declaración Columnas para cada fila
            Salarios[0] = new int[2];
            Salarios[1] = new int[5];
            Salarios[2] = new int[3];
            Salarios[3] = new int[4];
            Salarios[4] = new int[1];

            Salarios[0][0] = 9000;
            Salarios[0][1] = 8500;
            Salarios[1][0] = 9000;
            Salarios[1][1] = 8500;
            Salarios[1][2] = 8600;
            Salarios[1][3] = 6000;
            Salarios[1][4] = 3000;
            Salarios[2][0] = 5000;
            Salarios[2][1] = 800;
            Salarios[2][2] = 8500;
            Salarios[3][0] = 3500;
            Salarios[3][1] = 9500;
            Salarios[3][2] = 9000;
            Salarios[3][3] = 8500;
            Salarios[4][0] = 18000;

            ///Num1 Obtener el máximo número de elementos
            int Tamano = 0;
            int Maximo = 0;
            int iMaximo = 0;
            for(int i=0; i<Salarios.GetLength(0); i++)
            {
                Tamano = Salarios[i].Length;
                if(Tamano > Maximo)
                {
                    Maximo = Tamano;
                    iMaximo = i;
                }
            }
            Console.WriteLine("Valor Maximo " + Maximo + " Departamento con más empleados " + (iMaximo+1));
            ////2
            int VMax = 0;
            int iVMax = 0;
            for(int i = 0; i<Salarios.GetLength(0); i++)
            {
                for (int c=0; c < Salarios[i].Length; c++)
                {
                    if (Salarios[i][c] > VMax)
                    {
                        VMax = Salarios[i][c];
                        iVMax = i;
                    }                   
                }
            }
            Console.WriteLine("Salario Maximo " + VMax + " Departamento con Salario Mayor " + (iVMax + 1));
            ////3
            int VMin = Salarios[0][0];
            int iVMin = 0;
            for (int i = 0; i < Salarios.GetLength(0); i++)
            {
                for (int c = 0; c < Salarios[i].Length; c++)
                {
                    if (Salarios[i][c] < VMin)
                    {
                        VMin = Salarios[i][c];
                        iVMin = i;
                    }
                }
            }
            Console.WriteLine("Salario Mínimo " + VMin + " Departamento con Salario Mínimo " + (iVMin + 1));
            ////4
            int Acumulador;
            int AMax = 0;
            int iAMax = 0;
            for (int i = 0; i < Salarios.GetLength(0); i++)
            {
                //Acumula por fila
                Acumulador = 0;
                for (int c = 0; c < Salarios[i].Length; c++)
                {
                    Acumulador += Salarios[i][c];
                }
                if (Acumulador > AMax)
                {
                    iAMax = i;
                    AMax = Acumulador;
                }
            }
            Console.WriteLine("Departamento en el que más se gasta por concepto de pago de nóminas: " + (iAMax + 1) + ", con un total de: " + AMax);
        }
    }
}
