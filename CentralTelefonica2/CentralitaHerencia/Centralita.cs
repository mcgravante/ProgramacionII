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

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
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

        private string Mostrar()
        {
            StringBuilder centralitaMostrar = new StringBuilder();
            centralitaMostrar.Append("\nRazon social: ");
            centralitaMostrar.Append(this.razonSocial + "\n");
            centralitaMostrar.Append("\nGanancia Total: ");
            centralitaMostrar.Append(this.GananciasPorTotal + "\n");
            centralitaMostrar.Append("\nGanancia Local: ");
            centralitaMostrar.Append(this.GananciasPorLocal + "\n");
            centralitaMostrar.Append("\nGanancia Provincial: ");
            centralitaMostrar.Append(this.GananciasPorProvincial + "\n");
            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                {
                    centralitaMostrar.Append(((Local)llamada).ToString());
                }
                else
                {
                    centralitaMostrar.Append(((Provincial)llamada).ToString());
                }
            }
            return centralitaMostrar.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool contieneLlamada = false;
            foreach (Llamada l in c.Llamadas)
            {
                if (llamada == l)
                {
                    contieneLlamada = true;
                    break;
                }
            }
            return contieneLlamada;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            if (c == llamada)
            {
                return false;
            }
            return true;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }

        override
        public string ToString()
        {
            return this.Mostrar();
        }

    }
}
