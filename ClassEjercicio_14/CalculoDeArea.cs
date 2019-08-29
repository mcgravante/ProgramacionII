using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_14
{
  class CalculoDeArea
  {
    public static double CalcularCuadrado(double lado)
    {
      return lado * 4;
    }
    public static double CalcularTriangulo(double b, double h)
    {
      return (b * h) / 2;
    }
    public static double CalcularCirculo(double r)
    {
      return 3.14 * r * r;
    }

  }
}
