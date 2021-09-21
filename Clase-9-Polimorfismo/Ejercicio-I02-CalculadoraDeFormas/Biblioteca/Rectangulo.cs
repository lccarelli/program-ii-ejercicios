
namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        private float longitudBase;
        private float longitudAltura;

        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }

        public override double CalcularSuperficie()
        {
            return longitudBase * longitudAltura;
        }
        public override double CalcularPerimetro()
        {
            return (longitudAltura + longitudBase) * 2;
        }

        public override string Dibujar() 
        {
            return "Dibujar Rectangulo";
        }
    }
}
