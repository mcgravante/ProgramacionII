using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        #region "Atributos"
        private const int MEDIDA = 400;
        #endregion

        #region "Constructores"
        public Agua(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML) { }
        #endregion

        #region "Métodos"
        protected override string GenerarInforme()
        {
            StringBuilder informe = new StringBuilder();
            informe.Append(base.GenerarInforme());
            informe.Append("\nMedida: ");
            informe.Append(MEDIDA);
            return informe.ToString();
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }

        public int ServirMedida(int medida)
        {
            if (medida <= this.contenidoML)
            {
                this.contenidoML -= medida;
                return medida;
            }
            else
            {
                this.contenidoML = 0;
                return this.contenidoML;
            }
        }
        #endregion

    }
}
