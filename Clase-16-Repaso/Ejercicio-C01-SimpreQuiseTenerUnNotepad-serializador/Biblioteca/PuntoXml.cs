

using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXml<T> : Archivo, IArchivo<T> where T:class
    {
        protected override string Extension
        {
            get 
            {
                return ".xml";
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
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, contenido);
            }
        }

        private T Deserializar(string ruta)
        {
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return xmlSerializer.Deserialize(streamReader) as T;
            }
        }
    }

}
