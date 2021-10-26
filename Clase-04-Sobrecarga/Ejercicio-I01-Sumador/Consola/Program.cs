using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(4);

            Console.WriteLine(sumador1.Sumar(5,5));
            Console.WriteLine(sumador2.Sumar("Hola","mundo"));

            int s3 = (int)sumador2;
            Console.WriteLine(s3);


        }
    }
}
