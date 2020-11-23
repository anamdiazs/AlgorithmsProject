using System;

namespace PruebaAlgoritmos
{
    class Program
    {
        static int[] valores = new int[0];
        public static int totalComparacionesOXS = 0;
        public static int totalIntercambiosOXS = 0;
        public static int totalComparacionesOXM = 0;
        public static int totalIntercambiosOXM = 0;
        public static int totalComparacionesOXMon = 0;
        public static int totalIntercambiosOXMon = 0;
        public static int totalComparacionesOQS = 0;
        public static int totalIntercambiosOQS = 0;
        static int[] valoresOriginal = new int[0];      //Copia del vector aleatorio obtenido sin ordenar
        static void Main(string[] args)
        {
            GenerarNumeros(10);         //Genera un vector del tamaño del parámetro con números aleatorios
            //MostrarNumeros();           //Muestra los números sin Ordenar
            //valoresOriginal = (int[])valores.Clone();   //Guarda el vector original sin ordenar
            //OrdenarXBurbujaM();         //Método Burbuja Mejorado   (Quitar comentario para usar)
            //valoresOriginal.CopyTo(valores, 0);      //Regresa el vector a su forma sin ordenar inicial
            //OrdenarXBurbuja();        //Método Burbuja Normal     (Quitar comentario para usar)
            //valoresOriginal.CopyTo(valores, 0);      //Regresa el vector a su forma sin ordenar inicial
            OrdenarXSeleccion();        //Ordenación por selección      (Quitar comentario para usar)
            //valoresOriginal.CopyTo(valores, 0);     //Regresa el vector a su forma sin ordenar inicial
            //OrdenarXInsert();       //Ordenación por inserción      (Quitar comentario para usar)
            //valoresOriginal.CopyTo(valores, 0);     //Regresa el vector a su forma sin ordenar inicial
            //OrdenarXMezcla();       //Ordenación por Mezcla      (Quitar comentario para usar)
            valoresOriginal.CopyTo(valores, 0);     //Regresa el vector a su forma sin ordenar inicial
            heapSort(valores, valores.Length);      //Ordenación por Montículos     (Quitar comentario para usar)
            valoresOriginal.CopyTo(valores, 0);     //Regresa el vector a su forma sin ordenar inicial
            RadixSort(valores);         //Ordenación Radix      (Quitar comentario para usar)
            valoresOriginal.CopyTo(valores, 0);     //Regresa el vector a su forma sin ordenar inicial
            LlamadaQuickSort();      //Ordenación QuickSort      (Quitar comentario para usar)
            Console.WriteLine();        //Salto De Linea
            //MostrarNumeros();           //Muestra los números Ordenados
        }

        static void GenerarNumeros(int n)
        {
            Array.Resize(ref valores, n);
            Random Num = new Random();
            for (int i = 0; i<valores.Length; i++)
            {              
                int Numero = Num.Next(100);     //Genera números aleatorios del 0 al parámetro.
                valores[i] = Numero;
            }
        }

        static void MostrarNumeros()
        {
            for(int i = 0; i<valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }

        static void OrdenarXBurbujaM()
        {
            //MostrarNumeros();     //Muestra los números antes de ordenar
            int Aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;
            int intercambios = 0;

            do
            {
                intercambios = 0;
                for (int i = 0; i < valores.Length - 1; i++)
                {
                    if (valores[i] > valores[i + 1])
                    {
                        Aux = valores[i];
                        valores[i] = valores[i + 1];
                        valores[i + 1] = Aux;
                        totalIntercambios++;
                        totalComparaciones++;
                        intercambios++;
                    }
                    else
                    {
                        totalComparaciones++;
                    }
                }
                //Console.WriteLine(".......................");     //Ya se usa el mostrar números del método main
                //muestraArreglo(); //Por cada iteración
            } while (intercambios != 0);
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            //MostrarNumeros();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);
        }

        static void OrdenarXBurbuja()
        {
            //MostrarNumeros();     //Muestra los números antes de ordenar
            int Aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;

            for (int j = 0; j < valores.Length - 1; j++)
            {
                for (int i = 0; i < valores.Length - 1; i++)
                {
                    if (valores[i] > valores[i + 1])
                    {
                        Aux = valores[i];
                        valores[i] = valores[i + 1];
                        valores[i + 1] = Aux;
                        totalIntercambios++;
                        totalComparaciones++;
                    }
                    else
                    {
                        totalComparaciones++;
                    }
                }
                //Console.WriteLine(".......................");     //Ya se usa el mostrar números del método main
                //MostrarNumeros(); //Por cada iteración
            }
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            //MostrarNumeros();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);
        }

        static void OrdenarXSeleccion()
        {
            int auxiliar = 0;
            

            //MostrarNumeros();                                   //Muestra los números antes de ordenar
            int iLimite = valores.Length - 1;              //El índice Límite debe ser igual a la longitud del arreglo menos 1

            do
            {                                                        //Lo repite hasta que iLimite sea 0, entonces ahí con 0 ya no lo hace.
                int iMax = encuentraIndiceMaximo(iLimite);          //Encuentra el índice del valor máximo en un arreglo comparando desde el índice 0 hasta el índice iLimite
                if (valores[iMax] != valores[iLimite]) {                                                //Mejora el algoritmo al sólo hacer los intercambios necesarios (Compara si el valor a reemplazar es el mismo)
                auxiliar = valores[iLimite];                 //Guarda el valor de Ilimite en auxiliar
                valores[iLimite] = valores[iMax];     //Mete el Valor de IMax en el Ilimite
                valores[iMax] = auxiliar;                    //Mete el Valor de auxiliar en IMax
                totalIntercambiosOXS++;                            //Cuenta los intercambios totales
                }
                iLimite--;                                          //Disminuye el valor del límite en 1
            } while (iLimite > 0);
            //MostrarNumeros();                                   //Ya se usa el mostrar números del método main.
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparacionesOXS);
            Console.WriteLine("Total de Intercambios: " + totalIntercambiosOXS);
        }

        static int encuentraIndiceMaximo(int Limite)
        {
            int indiceMaximo = 0;
            for (int i = 0; i <= Limite; i++)
            {
                if (valores[i] > valores[indiceMaximo])
                {
                    indiceMaximo = i;
                }
                totalComparacionesOXS++;
            }
            return indiceMaximo;
        }

        static void OrdenarXInsert()
        {
            //MostrarNumeros();     //Muestra los números antes de ordenar
            int aux = 0;
            int totalComparaciones = 0;
            int totalIntercambios = 0;

            for (int clave = 1; clave < valores.Length; clave++)
            {
                int indice = clave;
                while (indice > 0)
                {
                    if (valores[indice] < valores[indice - 1])
                    {
                        aux = valores[indice - 1];
                        valores[indice - 1] = valores[indice];
                        valores[indice] = aux;
                        totalIntercambios++;
                    }
                    indice--;
                    totalComparaciones++;
                }
                //Console.WriteLine(".......................");     //Ya se usa el mostrar números del método main
                //muestraArreglo(); //Por cada iteración
            }
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            //MostrarNumeros();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);
        }

        static void OrdenarXMezcla()
        {
            //MostrarNumeros();     //Muestra los números antes de ordenar
            int[] mezcla1 = MergeSort(valores);
            mezcla1.CopyTo(valores, 0);
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            //MostrarNumeros();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparacionesOXM);
            Console.WriteLine("Total de Intercambios: " + totalIntercambiosOXM);
        }
        public static int[] MergeSort(int[] pLista)
        {
            //cantidad de elementos en el vector
            int cantidad = pLista.Length;
            //Cuando la lista ya está ordenada (cuando sólo tiene un elemento)
            if (cantidad < 2) 
            {
                return pLista;
            }

            //Punto medio
            int mitad = cantidad / 2;
            int segundamitad = cantidad - mitad;
            if (segundamitad < 1)
            {
                segundamitad = 1;
            }
            int[] izquierda = new int[mitad];
            int[] derecha = new int[segundamitad];

            int ci = 0;
            int cd = 0;
            //ponemos los valores de la izquierda
            for (int n = 0; n < mitad; n++)
            {
                izquierda[ci] = pLista[n];
                ci++;
            }
            //ponemos los valores de la derecha
            for (int i = mitad; i < cantidad; i++)
            {
                derecha[cd] = pLista[i];
                cd++;
            }

            //Recursión
            int[] tempI = MergeSort(izquierda);
            int[] tempD = MergeSort(derecha);

            //Hacemos el merge
            int[] ordenada = Merge(tempI, tempD);
            return ordenada;
        }
        public static int[] Merge(int[] listIzq, int[] listDer)
        {          
            int[] unida = new int[listIzq.Length + listDer.Length]; //lista donde se hará el merge
            //Indices de cada lista
            int indiceI = 0;
            int indiceD = 0;
            //cantidad de elementos
            int cantI = listIzq.Length;
            int cantD = listDer.Length;
            int c = 0;
            //recorremos los dos vectores que tengan elemntos sin procesar
            while (indiceI < cantI && indiceD < cantD)
            {
                //si el de la izquierda es menor o igual, agregamos el de la izquierda
                if (listIzq[indiceI] <= listDer[indiceD])
                {
                    unida[c] = listIzq[indiceI];
                    c++;
                    indiceI++;
                    totalComparacionesOXM++;
                    totalIntercambiosOXM++;
                }
                else //si el de la derecha es menor, agregamos el de la derecha
                {
                    unida[c] = listDer[indiceD];
                    c++;
                    indiceD++;
                    totalComparacionesOXM++;
                    totalIntercambiosOXM++;
                }
            }
            //Si sobraron elementos del vector izquierdo, los ponemos todos
            while (indiceI < cantI)
            {
                unida[c] = listIzq[indiceI];
                c++;
                indiceI++;
                //totalIntercambiosOXM++;
            }
            //Si sobraron elementos del vector izquierdo, los ponemos todos
            while (indiceD < cantD)
            {
                unida[c] = listDer[indiceD];
                c++;
                indiceD++;
                //totalIntercambiosOXM++;
            }
            return unida;
        }

        static void heapSort(int[] valores, int n)
        {
            //MostrarNumeros();     //Muestra los números antes de ordenar
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(valores, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = valores[0];
                valores[0] = valores[i];
                valores[i] = temp;
                heapify(valores, i, 0);
            }
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            //MostrarNumeros();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparacionesOXMon);
            Console.WriteLine("Total de Intercambios: " + totalIntercambiosOXMon);
        }
        static void heapify(int[] valores, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && valores[left] > valores[largest])
                largest = left;
            if (right < n && valores[right] > valores[largest])
                largest = right;
            if (largest != i)
            {
                int swap = valores[i];
                valores[i] = valores[largest];
                valores[largest] = swap;
                heapify(valores, n, largest);
                totalIntercambiosOXMon++;
            }
            totalComparacionesOXMon++;
        }

        static void RadixSort(int[] arr)
        {
            //MostrarNumeros();     //Muestra los números antes de ordenar
            int totalComparaciones = 0;
            int totalIntercambios = 0;
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                    totalComparaciones++;
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
                for(int k=0; k<j; k++)
                {
                    totalIntercambios++;
                }
            }
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            //MostrarNumeros();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparaciones);
            Console.WriteLine("Total de Intercambios: " + totalIntercambios);
        }

        public static void LlamadaQuickSort() 
        {
            //MostrarNumeros();     //Muestra los números antes de ordenar
            QuickSort(valores, 0, valores.Length);
            //Console.WriteLine(".....................");           //Ya se usa el mostrar números del método main
            //MostrarNumeros();
            Console.WriteLine();
            Console.WriteLine("Total de Comparaciones: " + totalComparacionesOQS);
            Console.WriteLine("Total de Intercambios: " + totalIntercambiosOQS);
        }
        public static int[] QuickSort(int[] arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivote = Particion(arr, inicio, fin);
                QuickSort(arr, inicio, pivote);
                QuickSort(arr, pivote + 1, fin);
            }           
            return arr;
        }
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            totalIntercambiosOQS++;
        }

        public static int Particion(int[] arr, int inicio, int fin)
        {
            int pivote = arr[inicio];
            int cambioIndice = inicio;
            for (int i = inicio + 1; i < fin; i++)
            {
                if (arr[i] < pivote)
                {
                    cambioIndice++;
                    Swap(arr, i, cambioIndice);
                }
                totalComparacionesOQS++;
            }
            Swap(arr, inicio, cambioIndice);
            return cambioIndice;
        }
    }
}
