using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        #region "Atributos"
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;
        #endregion

        #region "Propiedades"
        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }
        #endregion

        #region "Constructores"
        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }
        #endregion

        #region "Métodos"
        public static Cantina GetCantina(int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            bool ret = false;
            if ((c.botellas.Count < c.espaciosTotales))
            {
                c.botellas.Add(b);
                ret = true;
            }
            return ret;
        }
        #endregion


    }
}
