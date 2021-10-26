using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        short cilidrada;

        public Moto(short cilidrada, short cantidadRuedas, short cantidadPuertas, Colores color)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilidrada = cilidrada;
        }
    }
}
