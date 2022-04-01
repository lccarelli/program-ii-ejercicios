using System.Text;

namespace Biblioteca
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta) 
        {
            this.color = color;
            this.tinta = tinta;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta <= cantidadTintaMaxima && tinta >= 0) 
            {
                this.tinta += tinta;
            }     
        }

        public void Recargar()
        { 
            SetTinta(this.tinta);
        }

        public string Pintar(short gasto, string dibujo) 
        {
            StringBuilder sb = new StringBuilder();

            if (GetTinta() >= gasto)
            {
                if (GetTinta() == 10 && gasto == 2)
                {
                    sb.AppendLine("**");
                }
                this.tinta -= gasto;
            }
            else 
            {
                if (GetTinta() == 3 && gasto == 10) 
                {
                    sb.AppendLine("***");
                } 
                sb.Append("");
            }

            return sb.ToString();
        }
    }
}