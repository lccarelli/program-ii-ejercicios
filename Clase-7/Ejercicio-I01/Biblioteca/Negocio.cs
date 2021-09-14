using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio() 
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c) 
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (c == cliente) 
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Negocio n, Cliente c) 
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c) 
        {
            if (n != c) 
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
    }
}
