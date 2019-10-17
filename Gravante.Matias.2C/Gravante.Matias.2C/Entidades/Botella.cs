using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        #region "Atributos"
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region "Propiedades"
        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return this.contenidoML * 100 / this.capacidadML;
            }
        }
        #endregion

        #region "Contructores"
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            if (contenidoML > capacidadML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }
        }
        #endregion

        #region "Métodos"
        protected virtual string GenerarInforme()
        {
            StringBuilder informe = new StringBuilder();
            informe.Append("\nMarca: ");
            informe.Append(this.marca);
            informe.Append("\nContenido en ML ");
            informe.Append(this.contenidoML);
            informe.Append("\nCapacidad en ML ");
            informe.Append(this.capacidadML);
            informe.Append("\nPorcentaje Contenido ");
            informe.Append(this.PorcentajeContenido);
            return informe.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return this.GenerarInforme();
        }
        #endregion

        #region "Tipos"
        public enum Tipo { Plastico, Vidrio }
        #endregion
    }
}
