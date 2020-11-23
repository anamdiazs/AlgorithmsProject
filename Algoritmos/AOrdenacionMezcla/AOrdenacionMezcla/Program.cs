using System;

namespace AOrdenacionMezcla
{
    class Program
    {
        public static int[] mezcla = new int[] { 3, 6, 1, 2, 9, 0 };
        public static int arrL = mezcla.Length;
        static void Main(string[] args)
        {
            int[] mezcla1 = MergeSort(mezcla);
            for (int i = 0; i < mezcla1.Length; i++)
            {
                Console.WriteLine(mezcla1[i]);

            }
            Console.ReadLine();
        }
        public static int[] MergeSort(int[] pLista)
        {
            //cantidad de elementos en el vector
            int cantidad = pLista.Length;
            //Cuando la lista ya está ordenada (cuando sólo tiene un elemento)
            if (cantidad < 2) return pLista;

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
                }
                else //si el de la derecha es menor, agregamos el de la derecha
                {
                    unida[c] = listDer[indiceD];
                    c++;
                    indiceD++;
                }
            }
            //Si sobraron elementos del vector izquierdo, los ponemos todos
            while (indiceI < cantI)
            {
                unida[c] = listIzq[indiceI];
                c++;
                indiceI++;
            }
            //Si sobraron elementos del vector izquierdo, los ponemos todos
            while (indiceD < cantD)
            {
                unida[c] = listDer[indiceD];
                c++;
                indiceD++;
            }
            return unida;
        }
    }
}
