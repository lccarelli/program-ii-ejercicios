using System;

namespace Biblioteca
{
    public abstract class Figura
    {
        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();

        public virtual string Dibujar() 
        {
            return "Dibujar Forma";
        }
    }
}
