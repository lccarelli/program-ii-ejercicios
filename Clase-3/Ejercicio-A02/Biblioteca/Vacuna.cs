using System;

namespace Veterinaria
{
    public class Vacuna
    {
        private string nombre;

        public Vacuna(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}