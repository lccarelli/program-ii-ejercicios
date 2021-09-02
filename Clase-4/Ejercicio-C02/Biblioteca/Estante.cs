using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad) 
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante):this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos() 
        {
            return productos;
        }

        public static bool operator ==(Estante e, Producto p) 
        {
            for (int i = 0; i < e.productos.Length - 1; i++) 
            {
                if (e.productos[i] is not null)
                {
                    if (e.productos[i] == p)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p) 
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p) 
        {
            if (e != p) 
            {
                for (int i = 0; i < e.productos.Length; i++) 
                {
                    if (e.productos[i] is null) 
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p) 
        {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p) 
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            return e;

        }

        public static string MostrarEstante(Estante e) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion-> {e.ubicacionEstante}");
            for (int i = 0; i < e.productos.Length; i++) 
            {
                if (!(e.productos[i] is null)) 
                {
                    sb.AppendLine($"Marca-> {e.productos[i].GetMarca()} - Precio-> {e.productos[i].GetPrecio()}");
                }
            }

            return sb.ToString();
        }
    }
}
