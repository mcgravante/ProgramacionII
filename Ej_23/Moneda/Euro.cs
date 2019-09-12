using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar = 1.16;

        private Euro()
        {
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * cotizRespectoDolar);
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar eToD = (Dolar)(e);
            return (Pesos)(eToD);
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool ret = false;
            Euro e2 = (Euro)(d);
            if (e.GetCantidad() == e2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            bool ret = false;
            if (!(e == d))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool ret = false;
            Euro e2 = (Euro)(p);
            if (e.GetCantidad() == e2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            bool ret = false;
            if (!(e == p))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Euro e, Euro e2)
        {
            bool ret = false;
            if (e.GetCantidad() == e2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Euro e, Euro e2)
        {
            bool ret = false;
            if (!(e == e2))
            {
                ret = true;
            }
            return ret;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Dolar d2 = (Dolar)(e);
            return (Euro)(new Dolar(d2.GetCantidad() - d.GetCantidad()));
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Dolar d = (Dolar)(e);
            Dolar d2 = (Dolar)(p);
            return (Euro)(new Dolar(d.GetCantidad() - d2.GetCantidad()));
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Dolar d2 = (Dolar)(e);
            return (Euro)(new Dolar(d.GetCantidad() + d2.GetCantidad()));
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Dolar d = (Dolar)(e);
            Dolar d2 = (Dolar)(p);
            return (Euro)(new Dolar(d.GetCantidad() + d2.GetCantidad()));
        }
    }
}
