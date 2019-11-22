using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClaseAparte
    {
        public static string EstadoSimulacion(this bool estado)
        {
            if (estado == true)
            {
                return "Orbitando";
            }
            else
            {
                return "Detenido";
            }
        }
    }
}



