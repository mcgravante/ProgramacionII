using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto p in productos)
                {
                    if (((Guid)p).Equals(codigo))
                    {
                        return p;
                    }
                }
                return null;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();
            foreach (Producto p in this.productos)
            {
                diccionario.Add((Guid)p, p.Descripcion);
            }
            return diccionario;
        }

        public string ListarVentas()
        {
            this.OrdenarVentas();
            StringBuilder listarVentas = new StringBuilder();
            foreach (Venta v in this.ventas)
            {
                listarVentas.Append("\n" + v.ObtenerDescripcionBreve());
            }
            return listarVentas.ToString();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto p in comiqueria.productos)
                if (p.Descripcion.Equals(producto.Descripcion))
                {
                    return true;
                }
            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria == producto)
            {
                return false;
            }
            return true;
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            this.ventas.Add(venta);
        }

        public void OrdenarVentas()
        {
            this.ventas.Sort(Venta.OrdenarPorFecha);
        }
    }
}
