using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException : Exception
    {
        private String nombreClase;
        private String nombreMetodo;

        public String NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public String NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CentralitaException(String mensaje, String clase, String metodo)
            : this(mensaje, clase, metodo, null)
        {
        }

        public CentralitaException(String mensaje, String clase, String metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;

        }
    }
}
