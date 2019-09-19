using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre { get; set; }
        public int Numero { get; }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.Nombre = nombre;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            if (c1.Numero == c2.Numero)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1!=c2)
            {
                return false;
            }
            return true;
        }



    }
}
