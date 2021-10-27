using System.IO;
using System.Text.Json;

namespace IO
{
    public class PuntoJson<T> : Archivo, IArchivo<T> where T:class
    {
        protected override string Extension
        {
            get 
            {
                return ".json";
            }
        }
        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta)) 
            {
                Serializar(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta)) 
            {
                Serializar(ruta, contenido);
            }
        }

        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta)) 
            {
                return Deserializar(ruta);
            }
            return null;
        }

        private void Serializar(string ruta, T contenido) 
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                string json = JsonSerializer.Serialize(contenido);
                streamWriter.Write(json);
            }
        }

        private T Deserializar(string ruta) 
        {
            using (StreamReader streamReader = new StreamReader(ruta)) 
            {
                string json = streamReader.ReadToEnd();
                return JsonSerializer.Deserialize<T>(json);
            }
        }
    }
}
