using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Arbusto : Planta
    {
        protected override bool TieneFlores { get => false; }
        protected override bool TieneFrutos { get => false; }
        public Arbusto(string nombre, int tamanio) : 
            base(nombre, tamanio)
        { }

    }
}
