using System;

namespace Biblioteca
{
    public class UnCentro
    {
        /* 
         * Un centro numérico es un número que separa una lista de números enteros(comenzando en 1)
         * en dos grupos de números, cuyas sumas son iguales. El primer centro numérico es el 6,
         * el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son
         * ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a 49)
         * en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595. Se pide elaborar 
         * una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola. 
         */
        public static void TirameUnCentro(int numero) 
        {
            int uno = 0;
            int dos = 0;

            for (int i = 0; i < numero; i++) 
            {
                uno += i;

                for (int j = i + 2; j < numero; j++) 
                {
                    dos += j;
                    if (uno == dos) 
                    {
                        Console.WriteLine($"el centro numerico sera {0}", i + 1);
                        Console.WriteLine($"Separo la lista 1 a {2}, en 1-{0} y {1}-{2}.", i, i + 2, j);
                        Console.WriteLine($"Resultado {0}.", uno);
                    }
                }

                dos = 0;
            }
        } 
    }
}
