using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);

    public class Planeta
    {
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;
        public event InformacionDeAvance InformarAvance;

        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.velocidadTraslacion = velocidad;
            this.posicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.radioRespectoSol = radioRespectoSol;
        }

        #region Propiedades
        public short VelocidadTraslacion
        {
            get
            {
                return this.velocidadTraslacion;
            }
        }

        public short PosicionActual
        {
            get
            {
                return this.posicionActual;
            }
        }

        public short RadioRespectoSol
        {
            get
            {
                return this.radioRespectoSol;
            }
        }
        #endregion

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.posicionActual += velocidadTraslacion;
            return this.posicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                this.InformacionDeAvance(this, new PlanetaEventArgs(this.Avanzar(), this.radioRespectoSol));
                System.Threading.Thread.Sleep(60 + this.velocidadTraslacion);
            } while (true);
        }

        private void InformacionDeAvance(object sender, PlanetaEventArgs e)
        {
            this.InformarAvance.Invoke(sender, e);

        }

    }
}
