using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.Duracion * (int)this.franjaHoraria / 100;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public new string Mostrar()
        {
            StringBuilder llamadaProvincial = new StringBuilder();
            llamadaProvincial.Append(base.Mostrar());
            llamadaProvincial.Append("\nCosto de la Llamada: ");
            llamadaProvincial.Append(this.CostoLlamada + "\n");
            llamadaProvincial.Append("\nFranja Horaria: ");
            llamadaProvincial.Append(this.franjaHoraria + "\n");
            return llamadaProvincial.ToString();
        }

        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66,
        }
    }
}