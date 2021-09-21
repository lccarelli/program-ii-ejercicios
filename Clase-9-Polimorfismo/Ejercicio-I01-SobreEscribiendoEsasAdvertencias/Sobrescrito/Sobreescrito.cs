using System;

namespace Sobrescrito
{
    abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractas";
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public abstract string MiMetodo();



        public override string ToString()
        {
            return "Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
         
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
