using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial : Llamada
    {
        Franja franjaHoraria;

        public float CostoLlamada
        {
            get => CalcularCosto();
            set => costo = value;
        }

        public Provincial(Franja miFranja, Llamada llamada) 
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base( duracion, destino, origen) 
        {
        
        }

        private float CalcularCostro() 
        {
            
        }
    }
}
