using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get => CalcularCosto();
        }

        public Provincial(Franja miFranja, Llamada llamada) 
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        { }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base( duracion, destino, origen) 
        {
            this.franjaHoraria = miFranja;
        }

        public string Mostrar() 
        {
            StringBuilder sb = new();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat($" Costo de llamada: {0}", CostoLlamada);
            return sb.ToString();
        }

        private float CalcularCosto() 
        {
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    return base.Duracion * 0.99f;
                case Franja.Franja_2:
                    return base.Duracion * 1.25f;
                case Franja.Franja_3:
                    return base.Duracion * 0.66f;
            }
            return 0;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
