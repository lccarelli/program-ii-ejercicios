using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("tBasquet");
            Equipo e1 = new EquipoBasquet("Arsenal", DateTime.Now);
            Equipo e2 = new EquipoBasquet("Porvenir", DateTime.Now);

            torneoBasquet += e1;

            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo futbol");

            Equipo futbol1 = new EquipoFutbol("Indedendiente", DateTime.Now);
            Equipo futbol2 = new EquipoFutbol("Racing", DateTime.Now);

            torneoFutbol += futbol1;

            Console.WriteLine(torneoBasquet.Mostrar());
        }
    }
}
