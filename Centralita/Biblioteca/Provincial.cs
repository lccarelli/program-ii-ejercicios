using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }

        protected Franja franjaHoraria;

        public float CostoLlamada { get => CalcularCosto(); }

        public Provincial(Franja miFranja, Llamada llamada) : 
            base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) :
            base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()} - Costo: ${CostoLlamada:N2} - Franja Horaria: {franjaHoraria}");
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costofranja = (float)((int)franjaHoraria) / 100;
            return duracion * costofranja;
        }
    }
}
