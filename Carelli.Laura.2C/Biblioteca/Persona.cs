using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        private DateTime nacimiento;
        protected string nombre;

        protected int Edad 
        { 
            get
            {
                return DateTime.Today.AddTicks(this.nacimiento.Ticks).Year -1;
            }
        }

        protected string NombreCompleto
        {
            get
            {
                return String.Format("{0}, {1}", this.apellido, this.nombre);
            }
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }
        public Persona(string nombre, string apellido, string barrioResidencia, DateTime nacimiento)
            : this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        internal abstract string FichaExtra();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format(NombreCompleto));
            return sb.ToString();
        }

        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.ToString());
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine(p.FichaExtra());

            return sb.ToString();
        }
    }
}
