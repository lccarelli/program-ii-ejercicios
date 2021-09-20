using System;
using System.Collections.Generic;

namespace Veterinaria
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private long telefono;
        private List<Mascota> mascotas;

        public Cliente(string domicilio, string nombre, string apellido, long telefono, Mascota mascota)
        {
            this.Domicilio = domicilio;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.mascotas.Add(mascota);
        }

        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Telefono { get => telefono; set => telefono = value; }

        public List<Mascota> GetMascotas() 
        {
            return mascotas;
        }

        public void SetMascota(Mascota mascota) 
        {
            this.mascotas.Add(mascota);
        }

    }
}
