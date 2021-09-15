using System;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(short cantidadMarchas, short cantidadPasajeros, short cantidadRuedas, short cantidadPuertas, Colores color)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
                this.cantidadMarchas = cantidadMarchas;
                this.cantidadPasajeros = cantidadPasajeros;
         }
    }
}
