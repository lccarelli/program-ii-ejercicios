using System;

namespace Biblioteca
{
    public class Calculos
    {
        public static int maximo(int[] a) 
        {
            int maximo = 0;
            for (int i = 0; i < a.Length; i++) 
            {
                if (i == 0 || maximo < a[i]) 
                {
                    maximo = a[i];
                }
            }
            return maximo;
        }

        public static int minimo(int[] a) 
        {
            int minimo = 0;
            for (int i = 0; i < a.Length; i++) 
            {
                if (i == 0 || minimo > a[i]) 
                {
                    minimo = a[i];
                }
            }
            return minimo;
        }

        public static float promedio(int[] a) 
        {
            int acumulador = 0;
            int contador = 0;

            foreach (var item in a)
            {
                acumulador += item;
                contador++;
            }

            float promedio = acumulador / contador;
            return promedio;
        }
    }
}
