using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal Paciente Paciente { get => paciente; set => paciente = value; }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(paciente.FichaExtra());
            sb.AppendLine(String.Format("{0} se ha atendido a {0}", Fecha, Paciente));
            return sb.ToString();
        }
    }
}
