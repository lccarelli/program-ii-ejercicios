using System;
using System.Collections.Generic;
using Biblioteca;

namespace Consola
{
    class Program
    {
        private const int MAX = 100;
        private const int MIN = -100;

        static void Main(string[] args) 
        {
            List<int> numeros = pedirNumeros();
            int minimo = Validador.buscarMinimo(numeros);
            int maximo = Validador.buscarMaximo(numeros);
            float promedio = Validador.buscarPromedio(numeros);

            Console.WriteLine("El minimo es -> {0}", minimo);
            Console.WriteLine("El maximo es -> {0}", maximo);
            Console.WriteLine("El promedio es -> {0}", promedio);
        }
    

        private static List<int> pedirNumeros() 
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingresar 10 números: ");

            for (int i = 1; i == 10; i++) 
            {
                Console.WriteLine("Ingresar numero {0} ->", i);
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (Validador.validar(numero, MIN, MAX))
                    {
                        numeros.Add(numero);
                    }
                }
            }
            return numeros;
        }
    }
}
