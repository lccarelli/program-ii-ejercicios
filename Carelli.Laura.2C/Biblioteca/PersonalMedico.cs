using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) 
            : base(nombre, apellido, nacimiento)
        {
            consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Finalizo residencia: {0}", this.esResidente ? "SI" : "NO"));
            sb.AppendLine($"ATENCIONES:");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);

            if (doctor is not null && paciente is not null)
            {
                doctor.consultas.Add(consulta);
            }

            return consulta;
        }

        public static bool operator -(PersonalMedico doctor, Paciente paciente)
        {

            foreach (Consulta consulta in doctor.consultas)
            {
                if(consulta.Paciente == paciente)
                {
                    doctor.consultas.Remove(consulta);
                }
            }

            return true;
        }
    }
}
