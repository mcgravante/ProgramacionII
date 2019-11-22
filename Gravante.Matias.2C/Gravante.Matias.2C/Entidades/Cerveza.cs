using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        #region "Atributos"
        private const int MEDIDA = 330;
        private Tipo tipo;
        #endregion

        #region "Constructores"
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this(capacidadML, marca, Botella.Tipo.Vidrio, contenidoML) { }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Métodos"
        protected override string GenerarInforme()
        {
            StringBuilder informe = new StringBuilder();
            informe.Append(base.GenerarInforme());
            informe.Append("\nTipo: ");
            informe.Append(this.tipo);
            informe.Append("\nMedida: ");
            informe.Append(MEDIDA);
            return informe.ToString();
        }

        public override int ServirMedida()
        {
            if (MEDIDA <= this.contenidoML)
            {
                this.contenidoML -= MEDIDA;
                return 80 * MEDIDA / 100;
            }
            else
            {
                this.contenidoML = 0;
                return this.contenidoML;
            }
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
        #endregion


    }
}
