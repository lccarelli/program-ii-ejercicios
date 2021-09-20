using System;

namespace Biblioteca
{
    public class ErrorAlCubo
    {

        public static int PotenciaIterando(int b, int e) 
        {
            int result = 1;
            for (int i = 0; i < e; i++) 
            {
                result *= b;
            }

            return result;
        }

        public static double PotenciaConRecursividad(int b, int e) 
        {
            double result;

            if (e == 0)
                result = 1;
            else if (e < 0)
            {
                result = PotenciaConRecursividad(b, e + 1) / b;
            }
            else 
            {
                result = b * PotenciaConRecursividad(b, e - 1);
            }
                

            Console.WriteLine("{0}", result);
            return result;
        }

     
    }
}
