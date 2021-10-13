using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Factura : Documento
    {
        private int numero;

        public Factura(int numero) 
        {
            this.numero = numero;
        }

        public int Numero { get => numero; set => numero = value; }
    }
}
