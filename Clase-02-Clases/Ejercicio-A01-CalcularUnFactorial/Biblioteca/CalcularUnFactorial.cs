namespace Biblioteca
{

//El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números
//enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
//En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
    public class CalcularUnFactorial
    {

        public static int Calcular(int n)
        {
            if (Verificar(n))
                return Factorial(n);
            else
                throw new ArgumentException("No se puede calcular un factorial a CERO");

        }

        private static bool Verificar(int n)
        {
            if (n < 0) 
            {
                return false;
            }
            return true;
        }

        private static int Factorial(int n) 
        {
            int fact = 1;

            for (int i = 1; i<=n; i++) 
            {
                fact *= i;
            }

            return fact;
        }

    }
}