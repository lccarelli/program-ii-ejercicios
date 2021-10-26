using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrito
{
    class SobreSobrescrito : Sobreescrito
    {
        public SobreSobrescrito() { }

        public override string MiPropiedad { get => miAtributo; }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
