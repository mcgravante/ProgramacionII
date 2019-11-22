using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.Append("\nDuracion de la llamada: ");
            llamada.Append(this.Duracion + "\n");
            llamada.Append("\nNro de Destino: ");
            llamada.Append(this.NroDestino + "\n");
            llamada.Append("\nNro de Origen: ");
            llamada.Append(this.NroOrigen + "\n");
            return llamada.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2)
                && l1.NroOrigen == l2.NroOrigen
                && l1.NroDestino == l2.NroDestino)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            if (l1 == l2)
            {
                return false;
            }
            return true;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int ret = 0;
            if (llamada1.Duracion > llamada2.Duracion)
                ret = 1;
            if (llamada1.Duracion < llamada2.Duracion)
                ret = -1;
            return ret;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }


    }
}
