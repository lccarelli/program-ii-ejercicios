using System;
using System.Collections.Generic;

namespace Veterinaria
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private List<Vacuna> vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento) 
        { 
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.vacunas.Add(new Vacuna(""));
        }


        public string getEspecie() 
        {
            return especie;
        }        
        
        public string getNombre() 
        {
            return nombre;
        }

        public DateTime getFechaNacimiento() 
        {
            return fechaNacimiento;
        }

        public void CargarVacuna(Vacuna vacuna) 
        {
            this.vacunas.Add(vacuna);
        }
    }
}
