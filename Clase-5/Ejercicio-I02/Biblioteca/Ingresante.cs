using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private static List<string> cursos;
        private static int edad;
        private static string direccion;
        private static string genero;
        private static string nombre;
        private static string pais;

        public Ingresante(List<string> cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            Cursos = cursos;
            Direccion = direccion;
            Edad = edad;
            Genero = genero;
            Nombre = nombre;
            Pais = pais;
        }

        public static List<string> Cursos { get => cursos; set => cursos = value; }
        public static int Edad { get => edad; set => edad = value; }
        public static string Direccion { get => direccion; set => direccion = value; }
        public static string Genero { get => genero; set => genero = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Pais { get => pais; set => pais = value; }

        public static string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Ingresante:");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Genero: {genero}");
            sb.AppendLine($"Direccion: {direccion}");
            sb.AppendLine($"Pais: {pais}");
            sb.AppendLine("Cursos:");
            foreach (string curso in cursos)
            {
                sb.AppendLine($"{curso}");
            }
            

            return sb.ToString();
        }
    }
}
