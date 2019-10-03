using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }

        override
            public string ToString()
        {
            StringBuilder datosProducto = new StringBuilder();
            datosProducto.Append("\nDescripción: ");
            datosProducto.Append(this.Descripcion);
            datosProducto.Append("\nCódigo: ");
            datosProducto.Append((Guid)this);
            datosProducto.Append("\nPrecio: ");
            datosProducto.Append(this.Precio);
            datosProducto.Append("\nStock: ");
            datosProducto.Append(this.Stock);
            return datosProducto.ToString();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
    }
}
