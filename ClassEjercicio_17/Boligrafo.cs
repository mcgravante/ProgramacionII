using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_17
{
  class Boligrafo
  {
    public static short cantidadTintaMaxima = 100;
    private ConsoleColor color { get; set; }
    private short tinta { get; set; }

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }

    public ConsoleColor GetColor()
    {
      return this.color;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    public bool Pintar(short gasto, out string dibujo)
    {
      dibujo = "gaga";
      return true;
    }

    public void Recargar()
    {
      SetTinta(cantidadTintaMaxima);
    }

    private void SetTinta(short tinta)
    {
      int cantidadTinta = this.tinta + tinta;
      if (cantidadTinta>cantidadTintaMaxima)
      {
        cantidadTinta = cantidadTintaMaxima;
      }
     else  if (cantidadTinta >= 0)
      {
        this.tinta = (short)cantidadTinta;
      }
    }
  }
}
