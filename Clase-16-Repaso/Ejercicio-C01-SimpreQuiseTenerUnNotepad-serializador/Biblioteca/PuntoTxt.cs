using System;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                GuardarArchivo(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta)) 
            {
                return LeerArchivo(ruta);
            }

            return string.Empty;
        }

        private void GuardarArchivo(string ruta, string contenido) 
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta)) 
            {
                streamWriter.Write(contenido);
            }
        }

        private string LeerArchivo(string ruta) 
        {
            using (StreamReader streamReader = new StreamReader(ruta)) 
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
