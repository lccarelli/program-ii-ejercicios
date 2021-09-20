using System;
using Veterinaria;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Mascota mascotaSinVacuna = new Mascota("perro", "luke", new DateTime());

            Cliente cliente1 = new Cliente("vulcano", "spock", "no tiene", 66666666, mascotaSinVacuna);

        }
    }
}
