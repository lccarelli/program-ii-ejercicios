using System;

namespace Biblioteca
{
    public class Calculos
    {
        /*
         * Un numero perfecto es un entero positivo, que es igual a la suma de todos sus divisores
         * Por ejemmplo -> 
         * 6: divisores 1, 2, y 3
         * 1 + 2 + 3 = 6
         */
        public static void NumeroPerfecto() 
        {

            int numero = 1;
            int contador = 0;

            do
            {
                int acumulador = 0;
                for (int i = numero - 1; i > 0; i--) 
                {
                    if (numero % i == 0) 
                    {
                        acumulador += i;
                    }
                }

                if (acumulador == numero) 
                {
                    contador++;
                    Console.WriteLine($"{0} es numero perfecto", numero);
                }
                contador++;
            } while (contador<4);
        }
    }
}
