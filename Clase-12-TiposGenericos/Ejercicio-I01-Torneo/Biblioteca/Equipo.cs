using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        public Equipo(string nombre, DateTime fechaCreacion) 
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo e1, Equipo e2) 
        {
            return (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion) ? true : false;
        }

        public static bool operator !=(Equipo e1, Equipo e2) 
        {
            return !(e1 == e2);
        }

        public string Ficha() 
        {
            return $"{nombre} fundando el {fechaCreacion.ToString("dd/mm/yy")}";
        }
    }
}
