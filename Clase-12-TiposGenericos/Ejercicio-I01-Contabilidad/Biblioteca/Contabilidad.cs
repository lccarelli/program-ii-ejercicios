using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento
    {

        public List<T> egresos;
        public List<U> ingresos;


        public Contabilidad() 
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

    }
}
