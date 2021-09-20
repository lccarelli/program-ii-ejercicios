using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        short cantidadMarchas;
        int pesoCarga;

        public Camion(short cantidadMarchas, int pesoCarga, short cantidadRuedas, short cantidadPuertas, Colores color)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;

        }
    }
}
