using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca() 
        {
            return this.marca;
        }

        public float GetPrecio() 
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p) 
        {
            return $"Codigo -> {p.codigoDeBarra} Marca-> {p.marca} Precio-> {String.Format("{0:N2}", p.precio)}";
        }

        public static explicit operator string(Producto p) 
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2) 
        {
            return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, String a) 
        {
            return p.marca == a;
        }

        public static bool operator !=(Producto p, String a)
        {
            return !(p.marca == a);
        }
    }
}
