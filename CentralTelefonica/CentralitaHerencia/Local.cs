using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo = this.Duracion * this.costo;
            return costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public new string Mostrar()
        {
            StringBuilder llamadaLocal = new StringBuilder();
            llamadaLocal.Append(base.Mostrar());
            llamadaLocal.Append("\nCosto de la Llamada: ");
            llamadaLocal.Append(this.CostoLlamada + "\n");
            return llamadaLocal.ToString();
        }
    }
}
