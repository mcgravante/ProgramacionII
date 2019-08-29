using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_16
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumno1 = new Alumno();
      Alumno alumno2 = new Alumno();
      Alumno alumno3 = new Alumno();

      alumno1.legajo = 10001;
      alumno2.legajo = 10002;
      alumno3.legajo = 10003;

      alumno1.apellido = "apellido1";
      alumno2.apellido = "apellido2";
      alumno3.apellido = "apellido3";

      alumno1.nombre = "nombre1";
      alumno2.nombre = "nombre2";
      alumno3.nombre = "nombre3";

      alumno1.Estudiar(1, 6);
      alumno2.Estudiar(6, 6);
      alumno3.Estudiar(4, 6);

      Console.WriteLine(alumno1.Mostrar());
      Console.WriteLine(alumno2.Mostrar());
      Console.WriteLine(alumno3.Mostrar());
      Console.ReadKey();
    }
  }
}
