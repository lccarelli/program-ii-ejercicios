using System;


namespace Biblioteca
{
    public class Calculadora
    {
        private const int SUMAR = 1;
        private const int RESTAR = 2;
        private const int MULTIPLICAR = 3;
        private const int DIVIDIR = 4;

        public static float Calcular(float operando, float operador, int operacion) 
        {
            float result = 0;
            
            switch (operacion)
            {
                case SUMAR:
                    result = Sumar(operando, operador);
                    break;
                case RESTAR:
                    result = Restar(operando, operador);
                    break;
                case MULTIPLICAR:
                    result = Multiplicar(operando, operador);
                    break;
                case DIVIDIR:
                    result = Dividir(operando, operador);
                    break;
            }

            return result;
        }

        private static float Sumar(float operador, float operando) 
        {
            return operador + operando;
        }

        private static float Restar(float operador, float operando)
        {
            return operador - operando;
        }

        private static float Multiplicar(float operador, float operando)
        {
            return operador * operando;
        }

        private static float Dividir(float operador, float operando)
        {
            if (!Validar(operando))
            {
                return operador * operando;
            }
            else 
            {
                return operando;
            }
            
        }

        private static bool Validar(float numero) 
        {
            if (numero == 0)
                return true;
            else
                return false;
        }
    }
}
