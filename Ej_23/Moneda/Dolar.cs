using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar = 1;

        private Dolar()
        {
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool ret = false;
            Dolar d2 = (Dolar)(e);
            if (d.GetCantidad() == d2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            bool ret = false;
            if (!(d == e))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool ret = false;
            Dolar d2 = (Dolar)(p);
            if (d.GetCantidad() == d2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            bool ret = false;
            if (!(d == p))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Dolar d, Dolar d2)
        {
            bool ret = false;
            if (d.GetCantidad() == d2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            bool ret = false;
            if (!(d == d2))
            {
                ret = true;
            }
            return ret;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar d2 = (Dolar)(e);
            return new Dolar(d.GetCantidad() - d2.GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar d2 = (Dolar)(p);
            return new Dolar(d.GetCantidad() - d2.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar d2 = (Dolar)(e);
            return new Dolar(d.GetCantidad() + d2.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar d2 = (Dolar)(p);
            return new Dolar(d.GetCantidad() + d2.GetCantidad());

        }


    }
}
