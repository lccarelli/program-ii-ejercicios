using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Validador
    {
        public static bool validar(int valor, int min, int max) 
        {

            return (valor > min && valor < max) ? true : false;
        }

        public static int buscarMinimo(List<int> numeros) 
        {
            int min = 0;

            foreach (var item in numeros)
            {
                if (item < min) 
                {
                    min = item;
                }
            }

            return min;
        }

        public static int buscarMaximo(List<int> numeros) 
        {
            int max = 0;

            foreach (var item in numeros)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static float buscarPromedio(List<int> numeros) 
        {
            int suma = 0;
            int contador = 0;
            foreach (var item in numeros)
            {
                suma += item;
                contador++;
            }
            return suma / contador;
        }
    }
}
