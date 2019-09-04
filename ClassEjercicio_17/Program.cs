using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_17
{
  class Program
  {
    static void Main(string[] args)
    {
      Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
      String dibujo;

      Console.WriteLine("Boligrafo 1: ");
      Console.WriteLine("Color: {0}", boligrafo1.GetColor());
      Console.WriteLine("Nivel tinta: {0}", boligrafo1.GetTinta());
      Console.WriteLine("Pudo pintar: {0}", boligrafo1.Pintar(10, out dibujo));
      Console.WriteLine("Nivel tinta: {0}", boligrafo1.GetTinta());
      Console.WriteLine("Dibujo: {0}", dibujo);
      Console.WriteLine("Recargando tinta");
      Console.ReadKey();
      boligrafo1.Recargar();
      Console.WriteLine("Nivel tinta: {0}", boligrafo1.GetTinta());
      Console.ReadKey();

      Console.WriteLine("Boligrafo 2: ");
      Console.WriteLine("Color: {0}", boligrafo2.GetColor());
      Console.WriteLine("Nivel tinta: {0}", boligrafo2.GetTinta());
      Console.WriteLine("Pudo pintar: {0}", boligrafo2.Pintar(100, out dibujo));
      Console.WriteLine("Nivel tinta: {0}", boligrafo2.GetTinta());
      Console.WriteLine("Dibujo: {0}", dibujo);
      Console.WriteLine("Recargando tinta");
      Console.ReadKey();
      boligrafo2.Recargar();
      Console.WriteLine("Nivel tinta: {0}", boligrafo2.GetTinta());
      Console.ReadKey();

    }
  }
}

