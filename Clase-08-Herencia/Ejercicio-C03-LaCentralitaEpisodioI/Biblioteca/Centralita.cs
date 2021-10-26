using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita() 
        {
            this.listaDeLlamadas = new();
        }

        public Centralita(string nombreEmpresa) : this() 
        {
            this.razonSocial = nombreEmpresa;
        }

        public Centralita(List<Llamada> listaDeLlamadas, string razonSocial)
        {
            this.listaDeLlamadas = listaDeLlamadas;
            this.razonSocial = razonSocial;
        }

        public float GananciasPorLocal 
        {
            get => CalcularGanancia(Llamada.TipoLlamada.Local);        
        }

        public float GananciasPorProvincial
        {
            get => CalcularGanancia(Llamada.TipoLlamada.Provincial);
        }

        public float GananciasPorTotal
        {
            get => CalcularGanancia(Llamada.TipoLlamada.Todas);         
        }

        public List<Llamada> Llamadas
        {
            get => this.listaDeLlamadas;
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

        private string Mostrar() 
        {
            StringBuilder sb = new();
            sb.AppendLine($"RazonSocial-> {this.razonSocial}");
            sb.AppendLine($"GananciaTotal-> {GananciasPorTotal}");
            sb.AppendLine($"GananciaLocal-> {GananciasPorLocal}");
            sb.AppendLine($"GananciaProvincial-> {GananciasPorProvincial}");
            sb.AppendLine("Llamdas ->");
            foreach (Llamada item in Llamadas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public override string ToString() 
        {
            return this.Mostrar();
        }

        public void OrdenarLlamada() 
        {
            this.Llamadas.Sort((a, b) => Llamada.OrdenarPorDuracion(a, b));
        }

    }
}
