using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_13
{
  class Program
  {
    static void Main(string[] args)
    {
      String aux;
      Console.WriteLine("ingrese binario:");
      aux = Console.ReadLine();
      double valorDecimal=Conversor.BinarioDecimal(aux);
      Console.WriteLine("decimal: {0}", valorDecimal);
      Console.ReadKey();
      double valorDouble = 10.54;
      String valorBinario = Conversor.DecimalBinario(valorDouble);
      Console.WriteLine("binario: {0}", valorBinario);
      Console.ReadKey();
    }
  }
}
