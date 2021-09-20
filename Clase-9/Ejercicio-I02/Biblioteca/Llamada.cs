using System;

namespace Biblioteca
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            Duracion = duracion;
            NroDestino = nroDestino;
            NroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get => duracion;
            set => duracion = value;
        }

        public string NroDestino
        {
            get => nroDestino;
            set => nroDestino = value;
        }

        public string NroOrigen
        {
            get => nroOrigen;
            set => nroOrigen = value;
        }

        public static string Mostrar()
        {
            return "";
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2) 
        {
            return 1;
        } 
    }
}
