using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Local : Llamada
    {
        float costo;

        public float CostoLlamada 
        { 
            get => CalcularCosto();
        }

        public Local(Llamada llamada, float costo) 
            : this(costo, llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        { 
        }

        public Local(float costo, float duracion, string nroDestino, string nroOrigen)
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        private float CalcularCosto() 
        {
            return this.costo * base.Duracion;
        }

        public string Mostrar() 
        {
            StringBuilder sb = new();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat($" Costo de llamada: {0}", CostoLlamada);
            return sb.ToString();
        }

        
    }
}
