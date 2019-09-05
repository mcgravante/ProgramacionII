using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos { get; set; }
        private int ubicacionEstante { get; set; }

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static String MostrarEstante(Estante e)
        {
            String retorno = string.Format("Ubicación del Estante: {0}", e.ubicacionEstante);
            String productos = "";

            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                productos += Producto.MostrarProducto(e.GetProductos()[i]);
            }
            retorno += productos;
            return retorno;
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool ret = false;
            if (e.GetProductos().Contains<Producto>(p))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool ret = false;
            if (!(e==p))
            {
                ret = true;
            }
            return ret;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            bool ret = false;
            if (e.GetProductos().Contains<Producto>(p))
            {
                ret = true;
            }
            return ret;
        }

    }
}
