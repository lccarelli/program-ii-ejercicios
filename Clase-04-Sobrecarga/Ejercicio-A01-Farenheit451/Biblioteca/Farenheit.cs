using System;

namespace Biblioteca
{
    public class Farenheit
    {
        private const float GRADOS_FARENHEIT = 32F;
        private const float GRADOS_KELVIN = 459.67F;
        private float grados;

        public Farenheit() 
        { }

        public  Farenheit(Celsius c)
        {
            SetGrados(convertirCelsiusAFarenheit(c));
        }

        public Farenheit(Kelvin k) 
        {
            SetGrados(convertirKelvinAFarenheit(k));
        }

        public void SetGrados(float farenheit) 
        {
            this.grados = farenheit;
        }

        public float GetGrados() 
        {
            return this.grados;
        }

        public static float convertirCelsiusAFarenheit(Celsius c) 
        {
            return c.GetGrados() * 9 / 5 + GRADOS_FARENHEIT;
        }

        public static float convertirKelvinAFarenheit(Kelvin k) 
        {
            return k.GetGrados() * 9 / 5 - GRADOS_KELVIN;
        }
        public static bool operator ==(Farenheit f, Celsius c) 
        {
            return f === convertirCelsiusAFarenheit(c);
        }

        public static bool operator !=(Farenheit f, Celsius c) 
        {
            return !(f == c);
        }

        public static bool operator ==(Farenheit f, Kelvin k) 
        {
            return f === convertirKelvinAFarenheit(k);
        }

        public static bool operator !=(Farenheit f, Kelvin k) 
        {
            return !(f == k);
        }
    }
}
