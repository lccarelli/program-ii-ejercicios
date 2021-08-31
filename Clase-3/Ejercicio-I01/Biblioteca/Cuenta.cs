using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;


        public Cuenta(string titular, double cantidad) 
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string getTitular() 
        {
            return titular;
        }

        public double getCantidad() 
        {
            return cantidad;
        } 


        public string Mostrar() 
        {
            return $"Titular: {this.titular} - Cantidad: {this.cantidad}";
        }

        public void Ingresar(double monto) 
        {
            if (!EsNegativo(monto)) 
            {
                this.cantidad += monto;
            }

            
        }

        public void Retirar(double monto) 
        {
            if (!EsNegativo(monto)) 
            {
                this.cantidad -= monto;
            }
        
        }

        private static bool EsNegativo(double monto) 
        {
            return monto < 0 ? true : false;
        }
    }
}
