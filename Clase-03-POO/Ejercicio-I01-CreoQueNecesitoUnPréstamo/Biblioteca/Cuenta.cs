using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }

        public string Titular { get => titular; set => titular = value; }
        public decimal Cantidad { get => cantidad; set => cantidad = value; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Datos de la cuenta: {0} y la cantidad es: {1}", Titular, Cantidad);
            return sb.ToString();
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0) 
            {
                Cantidad += monto;
            }
        }

        public void Retirar(decimal monto) 
        {
            if (monto < Cantidad) 
            {
                Cantidad -= monto;
            }        
        }
    }
}