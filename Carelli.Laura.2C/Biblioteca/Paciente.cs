using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paciente : Persona
    {
        public enum EDiagnostico
        {
            CURADO,
            GRIPE,
            CORONAVIRUS
        }

        private string diagnostico;

        public EDiagnostico RandomEnum<EDiagnostico>() 
        {
            EDiagnostico[] values = (EDiagnostico[])Enum.GetValues(typeof(EDiagnostico)); 
            return values[new Random().Next(0, values.Length)]; 
        }

        public string Diagnostico 
        { 
            get => diagnostico;
            set 
            {
                this.diagnostico = RandomEnum<EDiagnostico>().ToString();
            }
        }

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) 
            : base(nombre, apellido, barrioResidencia, nacimiento)
        {
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Reside en :{base.barrioResidencia}");
            sb.AppendLine($"Diagnostico: {Diagnostico}");
            return sb.ToString();
        }
    }
}
