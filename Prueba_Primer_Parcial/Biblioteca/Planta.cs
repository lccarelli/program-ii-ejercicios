using System.Text;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public int Tamanio { get => tamanio;}

        protected abstract bool TieneFlores { get; }

        protected abstract bool TieneFrutos { get; }

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} tiene un tamanio {this.tamanio}");
            sb.AppendLine(String.Format("Tiene flores: {0}", this.TieneFlores ? "SI":"NO"));
            sb.AppendLine(String.Format("Tiene frutos: {0}", this.TieneFrutos ? "SI" : "NO"));

            return sb.ToString();
        }
    }
}