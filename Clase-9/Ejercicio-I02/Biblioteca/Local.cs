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
            set => costo = value;
        }

        public Local(float costo, float duracion, string nroDestino, string nroOrigen)
            : base(duracion, nroDestino, nroOrigen)
        {
            CostoLlamada = costo;
        }

        private float CalcularCosto() 
        {
            return this.costo * Duracion;
        }

        public static string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("");
            return sb.ToString;
        }

        
    }
}
