using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar = 38.33;

        private Pesos()
        {
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad, cotizRespectoDolar);
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar pToD = (Dolar)(p);
            return (Euro)(pToD);
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool ret = false;
            Pesos p2 = (Pesos)(d);
            if (p.GetCantidad() == p2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            bool ret = false;
            if (!(p == d))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool ret = false;
            Pesos p2 = (Pesos)(e);
            if (p.GetCantidad() == p2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            bool ret = false;
            if (!(p == e))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Pesos p, Pesos p2)
        {
            bool ret = false;
            if (p.GetCantidad() == p2.GetCantidad())
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Pesos p, Pesos p2)
        {
            bool ret = false;
            if (!(p == p2))
            {
                ret = true;
            }
            return ret;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Dolar d2 = (Dolar)(p);
            return (Pesos)(new Dolar(d2.GetCantidad() - d.GetCantidad()));
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Dolar d = (Dolar)(p);
            Dolar d2 = (Dolar)(e);
            return (Pesos)(new Dolar(d.GetCantidad() - d2.GetCantidad()));
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Dolar d2 = (Dolar)(p);
            return (Pesos)(new Dolar(d.GetCantidad() + d2.GetCantidad()));
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Dolar d = (Dolar)(p);
            Dolar d2 = (Dolar)(e);
            return (Pesos)(new Dolar(d.GetCantidad() + d2.GetCantidad()));
        }
    }
}
