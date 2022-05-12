using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Local : Llamada
    {
        private float costo;

        public float CostoLlamada { get => CalcularCosto(); }

        public Local(Llamada llamada, float costo) : 
            base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
        }
        public Local(string origen, float duracion, string destino, float costo) :
            this(new Llamada(duracion, destino, origen), costo)
        {
        } 

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()} - Costo: ${CostoLlamada}");
            return sb.ToString();
        }

        protected float CalcularCosto()
        {
            return duracion * costo;
        }

    }
}
