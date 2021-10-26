
using System;

namespace Biblioteca
{
    public sealed class Circulo : Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }

        public override string Dibujar()
        {
            return "Dibujar Circulo";
        }
    }
}
