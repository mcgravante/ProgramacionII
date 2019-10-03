using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioFinalSinIva = precioUnidad * cantidad;
            double precioFinalConIva = precioFinalSinIva + (precioFinalSinIva * porcentajeIva / 100);
            return precioFinalConIva;
        }

        public string ObtenerDescripcionBreve()
        {
            return string.Format("{0}-{1}-{2:#.##}", 
                this.Fecha, this.producto.Descripcion, this.precioFinal);
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        public static int OrdenarPorFecha(Venta v1, Venta v2)
        {
            int ret = 0;
            if (v1.Fecha > v2.Fecha)
                ret = 1;
            if (v1.Fecha < v2.Fecha)
                ret = -1;
            return ret;
        }
    }
}
