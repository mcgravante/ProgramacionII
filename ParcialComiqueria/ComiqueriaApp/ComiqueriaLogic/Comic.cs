using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic)
            :base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        override
            public string ToString()
        {
            StringBuilder datosComic = new StringBuilder();
            datosComic.Append(base.ToString());
            datosComic.Append("\nAutor: ");
            datosComic.Append(this.autor);
            datosComic.Append("\nTipoComic: ");
            datosComic.Append(this.tipoComic);
            return datosComic.ToString();
        }

        public enum TipoComic
        {
            Occidental,
            Oriental,
        }
    }
}
