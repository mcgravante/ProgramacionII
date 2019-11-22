using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IFiles<T>
    {
        #region Métodos
        void Guardar(string nombreArchivo, T objeto);
        void Guardar(string nombreArchivo, T objeto, Encoding encode);
        bool Leer(string nombreArchivo, out T objeto);
        bool Leer(string nombreArchivo, out T objeto, Encoding encode);
        #endregion
    }
}
