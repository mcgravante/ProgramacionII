using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private String codigoDeBarra { get; set; }
        private String marca { get; set; }
        private float precio { get; set; }

        Producto(String marca, String codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public static explicit operator String(Producto p)
        {
            return p.codigoDeBarra;
        }

        public String GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static bool operator ==(Producto p, String marca)
        {
            bool ret = false;
            if (p.GetMarca() == marca)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Producto p, String marca)
        {
            bool ret = false;
            if (!(p == marca))
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ret = false;
            if (p1.GetMarca() == p2.GetMarca() &&
                (String)p1 == (String)p2)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool ret = false;
            if (!(p1 == p2))
            {
                ret = true;
            }
            return ret;
        }
        public static string MostrarProducto(Producto p)
        {
            return string.Format("Marca: {0}, Precio: {1}, " +
                "Codigo de Barras: {2}\n", p.GetMarca(), p.GetPrecio(), (String)p);
        }
    }
}
