using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class MiClase
    {

        int atributo;

        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("falló");
        }

        public void MetodoDeInstancia()
        {

        }

        public MiClase()
        {
            try
            {
                this.atributo = 0;
                MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException("falló constructor", e);
            }
        }

        public MiClase(int parametro)
        {
            try
            {
                MiClase ejemploTrucho = new MiClase();
                ejemploTrucho.atributo = parametro;
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("falló segundo constructor", e);

            }
        }
        public class UnaException : Exception
        {
            public UnaException(string messagge, Exception inner)
                : base(messagge, inner)
            {
            }

        }
    }
}

