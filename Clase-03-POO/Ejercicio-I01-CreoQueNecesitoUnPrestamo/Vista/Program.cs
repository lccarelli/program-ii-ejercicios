using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cuenta c1 = new Cuenta("Luke Skywalker", 333.33);

            Console.WriteLine("la cuenta es de -> {0} y tiene -> {1}", c1.getTitular(), c1.getCantidad());

            c1.Retirar(20);

            Console.WriteLine("se retiro -> 20 y queda -> {1}", c1.getCantidad());
            c1.Ingresar(200);


        }
    }
}
