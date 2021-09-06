using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Celsius
    {
        private const float GRADOS_FARENHEIT = -32F;
        private float grados;

        public Celsius() 
        { }

        public Celsius(Farenheit f) 
        {
            SetGrados(convertirFrenheitACelsius(f));
        }

        public void SetGrados(float celsius) 
        {
            this.grados = celsius;
        }

        public float GetGrados() 
        {
            return this.grados;
        }

        public static float convertirFrenheitACelsius(Farenheit f) 
        {
            return f.GetGrados() + GRADOS_FARENHEIT * 5 / 9;
        }

    }

}
