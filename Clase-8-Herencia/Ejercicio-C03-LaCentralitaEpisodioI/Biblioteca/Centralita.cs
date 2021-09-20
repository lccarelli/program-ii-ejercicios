using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Centralita
    {
        List<Llamada> listaDeLlamadas;
        string razonSocial;

        public Centralita() { }

        public Centralita(List<Llamada> listaDeLlamadas, string razonSocial)
        {
            this.listaDeLlamadas = listaDeLlamadas;
            this.razonSocial = razonSocial;
        }

        public float GananciasPorLocal 
        {
            get 
            {
                return 0;
            }        
        }

        public float GananciasPorProvincial
        {
            get
            {
                return 0;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return 0;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo) 
        {
            float costoLlamada = 0;
            foreach (Llamada item in Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (item is Local) costoLlamada += item.CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial) costoLlamada += item.CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        costoLlamada += item.CostoLlamada;
                        break;
                }
            }
            return costoLlamada;
        }

        public string Mostrar() 
        {
            return "";
        }

        public void OrdenarLlamada() 
        {
            
        }

    }
}
