using System.Text;

namespace Biblioteca
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get => duracion;}
        public string NroDestino { get => nroDestino;}
        public string NroOrigen { get => nroOrigen;}

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append($"Numero Origen: {nroOrigen} - Numero Destino: {nroDestino} - Duracion: {duracion}");
            return retorno.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            if(llamadaUno.duracion > llamadaDos.duracion)
            {
                return 1;
            }
            return 0;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}