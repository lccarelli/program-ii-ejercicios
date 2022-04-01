using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante() 
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void setNotaPrimerParcial(int nota) 
        {
            this.notaPrimerParcial = nota;
        }

        public void setNotaSegundoParcial(int nota) 
        {
            this.notaSegundoParcial = nota;
        }

        private double CalcularPromedio() 
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal() 
        {
            if (EsAprobado(this.notaPrimerParcial) && EsAprobado(this.notaSegundoParcial))
            {
                return Math.Pow(6, 11);
            }
            else 
            {
                return -1;
            }
            
        }

        private bool EsAprobado(int nota) 
        {
            return nota > 4 ? true : false;
        }

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}, Apellido: {1}, Legajo: {0}", this.nombre, this.apellido, this.legajo);

            return sb.ToString();
        }

    }
}
