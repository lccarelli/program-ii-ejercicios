using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Recibo : Documento
    {
        int numero;

        public Recibo()
        {
        }

        public Recibo(int numero) : base(numero)
        {
            this.numero = numero;
        }
    }
}
