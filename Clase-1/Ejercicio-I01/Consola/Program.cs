using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Ingrese 10 numeros:");
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Ingrese numero {0}:", i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("El maximo numero ingresado es -> {0}",Calculos.maximo(numbers));
            Console.WriteLine("El minimo numero ingresado es -> {0}",Calculos.minimo(numbers));
            Console.WriteLine("El promedio es -> {0}",Calculos.promedio(numbers));
        }
    }
}
