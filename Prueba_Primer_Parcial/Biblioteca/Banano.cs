using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Banano : Planta
    {
        private string codigo;

        protected override bool TieneFlores { get => true; }
        protected override bool TieneFrutos { get => true; }

        public Banano(string nombre, int tamanio, string codigo) : 
            base(nombre, tamanio)
        {
            this.codigo = codigo;
        }

        public override string ResumenDeDatos() 
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Codigo internacional: {this.codigo}");
            return sb.ToString(); 
        }
    }
}
