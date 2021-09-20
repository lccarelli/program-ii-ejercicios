﻿using System;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero)
        {
            Nombre = nombre;
            this.numero = numero;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }

        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.nombre == c2.nombre && c1.numero == c2.numero ? true : false;
        }

        public static bool operator !=(Cliente c1, Cliente c2) 
        {
            return !(c1 == c2);
        }
    }
}
