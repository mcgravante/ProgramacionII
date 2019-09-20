using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
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
            float ganancia = 0;
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamada in this.Llamadas)
                    {
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada llamada in this.Llamadas)
                    {
                        if (llamada is Provincial)
                            ganancia += ((Provincial)llamada).CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    ganancia = CalcularGanancia(Llamada.TipoLlamada.Provincial)
                        + CalcularGanancia(Llamada.TipoLlamada.Local);
                    break;
                default:
                    break;
            }
            return ganancia;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder centralita = new StringBuilder();
            centralita.Append("\nRazon social: ");
            centralita.Append(this.razonSocial + "\n");
            centralita.Append("\nGanancia Total: ");
            centralita.Append(this.GananciasPorTotal + "\n");
            centralita.Append("\nGanancia Local: ");
            centralita.Append(this.GananciasPorLocal + "\n");
            centralita.Append("\nGanancia Provincial: ");
            centralita.Append(this.GananciasPorProvincial + "\n");
            this.OrdenarLlamadas();
            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                {
                    centralita.Append(((Local)llamada).Mostrar());
                }
                else
                {
                    centralita.Append(((Provincial)llamada).Mostrar());
                }
            }
            return centralita.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }


    }
}
