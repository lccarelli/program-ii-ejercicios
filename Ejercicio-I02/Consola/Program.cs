using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {

                Console.WriteLine("Ingrese un numero->");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero < 0) {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numero < 0);

            Console.WriteLine(
                "La potencia cuadrada de -> {0} es ->{1}",
                numero,
                ErrorAlCubo.PotenciaConRecursividad(numero, 2)
                );

            Console.WriteLine(
                "La potencia al cubo de -> {0} es ->{1}",
                numero,
                ErrorAlCubo.PotenciaConRecursividad(numero, 3)
                );

        }
    }
}
