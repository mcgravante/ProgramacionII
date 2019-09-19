using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get; }
        public string NroDestino { get; }
        public string NroOrigen { get; }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            return "completar";
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return 0;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }


    }
}
