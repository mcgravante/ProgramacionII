using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                
            }
        }
        private Negocio()
        { }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            if (n == c)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            if (n.clientes.Contains(c))
            {
                return true;
            }
            return false;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
    }
}
