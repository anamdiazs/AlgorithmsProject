using System;

namespace AOrdenacionShell
{
    class Program
    {
        static int n = 10;
        //static int[] arreglo = new int[n];
        static int[] arreglo = { 4, 8, 7, 2, 9, 1, 3 };
        static int comparaciones = 0, intercambios = 0;

        static void Main(string[] args)
        {
            //llenaArreglo();

            int intervalo = (arreglo.Length / 2);
            int aux = 0;
            int i = 0;
            int iPrincipal = 0;

            while (intervalo > 0)
            {
                if (arreglo[iPrincipal] > arreglo[iPrincipal + intervalo])
                {
                    //Intercambio normal
                    aux = arreglo[iPrincipal];
                    arreglo[iPrincipal] = arreglo[iPrincipal + intervalo];
                    arreglo[iPrincipal + intervalo] = aux;
                    intercambios++;

                    i = iPrincipal;
                    //Checar en índices anteriores
                    while (i - intervalo >= 0)
                    {
                        comparaciones++;
                        if (arreglo[i] < arreglo[i - intervalo])
                        {
                            aux = arreglo[i];
                            arreglo[i] = arreglo[i - intervalo];
                            arreglo[i - intervalo] = aux;
                            intercambios++;

                            i -= intervalo;
                        }
                        else break;
                    }
                }
                comparaciones++;
                iPrincipal += intervalo;

                //Checar si nos excedemos del length del arreglo
                if (iPrincipal + intervalo >= arreglo.Length)
                {
                    iPrincipal = 0;
                    intervalo /= 2;
                }
            }

            mostrarArreglo();
            Console.WriteLine("Comparaciones:" + comparaciones);
            Console.WriteLine("Intercambios:" + intercambios);

            Console.ReadLine();
        }

        static void llenaArreglo()
        {
            Random r = new Random();
            for (int i = 0; i < arreglo.Length; i++) arreglo[i] = r.Next(n);
        }

        static void mostrarArreglo()
        {
            for (int i = 0; i < arreglo.Length; i++) Console.WriteLine(arreglo[i]);
        }
    }
}
