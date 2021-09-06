using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Kelvin
    {
        private const float GRADOS_KELVIN = 459.67F;
        private float grados;

        public Kelvin() 
        { }

        public Kelvin(Farenheit f) 
        {
            SetGrados(convertirFarenheintAKelvin(f));
        }

        public void SetGrados(float kelvin) 
        {
            this.grados = kelvin;
        }

        public float GetGrados() 
        {
            return this.grados;
        }

        public static float convertirFarenheintAKelvin(Farenheit f) 
        {
            return f.GetGrados() + GRADOS_KELVIN * 5 / 9;
        }
    }
}
