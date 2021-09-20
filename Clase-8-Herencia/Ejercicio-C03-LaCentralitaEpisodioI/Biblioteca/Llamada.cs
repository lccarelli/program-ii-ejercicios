using System;
using System.Text;

namespace Biblioteca
{
    public  abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get => duracion;
        }

        public string NroDestino
        {
            get => nroDestino;
        }

        public string NroOrigen
        {
            get => nroOrigen;
        }

        public abstract float CostoLlamada { get; }
        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendFormat($"Origen: {0} | Destino: {1} | Duracion: {2}mins |", NroOrigen, NroDestino, Duracion);
            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2) 
        {
            return l1.NroDestino == l2.NroDestino && l1.nroOrigen == l2.nroOrigen;

        }

        public static bool operator !=(Llamada l1, Llamada l2) 
        {
            return !(l1 == l2);
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2) 
        {
            if (llamada1.Duracion > llamada2.Duracion) return 1;
            if (llamada1.Duracion == llamada2.Duracion) return 0;
            return 1;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
