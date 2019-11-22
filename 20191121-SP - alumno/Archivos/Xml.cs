using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        #region Propiedades
        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            }
        }
        #endregion

        #region Métodos
        public bool FileExists(string nombreArchivo)
        {
            return File.Exists(GetDirectoryPath + nombreArchivo);
        }

        public void Guardar(string nombreArchivo, T objeto)
        {
            Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encode)
        {
            if (!(nombreArchivo is null))
            {
                XmlWriter writer = null;
                try
                {
                    writer = new XmlTextWriter(nombreArchivo, encode);
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, objeto);
                }
                catch (Exception e)
                {
                    throw new ErrorArchivosException(e);
                }
                finally
                {
                    if (!(writer is null))
                    {
                        writer.Close();
                    }
                }
            }
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            return Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }


        public bool Leer(string nombreArchivo, out T objeto, Encoding encode)
        {
            bool retorno = false;
            objeto = default(T);
            if (!(nombreArchivo is null))
            {
                XmlReader lector = null;
                try
                {
                    lector = new XmlTextReader(nombreArchivo);
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    objeto = (T)serializador.Deserialize(lector);
                    retorno = true;
                }
                catch (Exception e)
                {
                    throw new ErrorArchivosException(e);
                }
                finally
                {
                    if (!(lector is null))
                    {
                        lector.Close();
                    }
                }
            }
            return retorno;
        }
        #endregion
    }
}