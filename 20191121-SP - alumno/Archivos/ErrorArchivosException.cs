using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivosException:Exception
    {
        #region Constructores
        public ErrorArchivosException(Exception innerException) : base("Archivo no se guardó o no se escribió", innerException)
        { }
        #endregion
    }
}
