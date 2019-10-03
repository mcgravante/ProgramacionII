using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;

        public Figura(int stock, double precio, double altura) 
            : this("Figura " + altura.ToString() + " cm", stock, precio, altura)
        {
        }

        public Figura(string descripcion, int stock, double precio, double altura) 
            : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }

        override
            public string ToString()
        {
            StringBuilder datosFigura = new StringBuilder();
            datosFigura.Append(base.ToString());
            datosFigura.Append("\nAltura: ");
            datosFigura.Append(this.altura);
            return datosFigura.ToString();
        }
    }
}
