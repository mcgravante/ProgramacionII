using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void LoadWrongFile()
        {
        }
    }
}
