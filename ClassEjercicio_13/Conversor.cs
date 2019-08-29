using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_13
{
  class Conversor
  {
    public static string DecimalBinario(double val)
    {
      return val.ToString();
    }

    public static double BinarioDecimal(string val)
    {
      double ret;
      double.TryParse(val, out ret);
      return ret;
    }
  }
}
