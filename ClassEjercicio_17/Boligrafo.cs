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
      bool ret = false;
      dibujo = "";
      if (this.tinta - gasto >= 0)
      {
        SetTinta((short)-gasto);
        for (int i = 0; i < gasto; i++)
        {
          dibujo += "*";
        }
        ret = true;
      }
      else
      {
        for (int i = this.tinta; i > 0; i--)
        {
          dibujo += "*";
        }
        SetTinta((short)-this.tinta);
        ret = false;
      }
      return ret;
    }

    public void Recargar()
    {
      SetTinta(cantidadTintaMaxima);
    }

    private void SetTinta(short tinta)
    {
      int cantidadTinta = this.tinta + tinta;
      if (cantidadTinta >= cantidadTintaMaxima)
      {
        this.tinta = cantidadTintaMaxima;
      }
      else if (cantidadTinta >= 0 && cantidadTinta < cantidadTintaMaxima)
      {
        this.tinta = (short)cantidadTinta;
      }
    }
  }
}
