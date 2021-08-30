using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Primos
    {
        public static List<int> numerosPrimos(int n) 
        {

            List<int> numerosPrimos = new List<int>();

            if (isZero(n))
            {
                Console.WriteLine("Este numero no es apto");
            }
            else 
            {
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 != 0)
                    {
                        numerosPrimos.Add(i);
                    }
                }
            }

            return numerosPrimos;
        }

        public static bool isZero(int n) {
            if (n < 1) 
            {
                return true;
            }

            return false;
        }
    }
}
