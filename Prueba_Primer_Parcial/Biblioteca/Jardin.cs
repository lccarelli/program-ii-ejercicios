using System.Text;

namespace Biblioteca
{
    public class Jardin
    {
        /// <summary>
        /// Enum con opciones de tipo de suelo
        /// </summary>
        public enum Tipo
        {
            TERROZO,
            ARENOZO
        }

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        static Jardin()
        {
            Jardin.suelo = Jardin.Tipo.TERROZO;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal)
            : this()
        {
            this.espacioTotal = espacioTotal;
        }

        public static bool operator -(Jardin jardin, Planta planta)
        {
            return false;
        }

        private int EspacioOcupado() 
        {
            int espacioTotal = 0;

            foreach (Planta planta in plantas)
            {
                espacioTotal += planta.Tamanio;
            }
            return espacioTotal;
        }
        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if (jardin is not null && planta is not null && jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composicion del jardin {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine("LISTA DE PLANTAS:");

            foreach (Planta planta in this.plantas)
            {
                sb.AppendLine(planta.ResumenDeDatos());
            }
            return sb.ToString();
        }

    }
}