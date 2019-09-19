using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get; }
        public float GananciasPorProvincial { get; }
        public float GananciasPorTotal { get; }
        public List<Llamada> Llamadas {get;}

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            return 0;
        }

        public Centralita()
        { }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            return "completar";
        }

        public void OrdenarLlamadas()
        { }


    }
}
