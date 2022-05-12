using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rosal : Planta
    {
        public enum Color
        {
            ROJA,
            BLANCA,
            AMARILLA,
            ROSA,
            AZUL
        }

        private Color color;

        protected override bool TieneFlores 
        { 
            get => true; 
        }
        protected override bool TieneFrutos 
        { 
            get => false; 
        }

        public Rosal(string nombre, int tamanio) 
            : this(nombre, tamanio, Color.ROSA)
        {
        }

        public Rosal(string nombre, int tamanio, Color flor)
            : base(nombre, tamanio)
        {
            this.color = flor;
        }

        public override string ResumenDeDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Flores de color: {this.color}");
            return sb.ToString(); 
        }
    }
}
