using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_16
{
  class Alumno
  {
    private byte nota1 { get; set; }
    private byte nota2 { get; set; }
    private float notaFinal { get; set; }
    public int legajo { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }

    public void Estudiar(byte nota1, byte nota2)
    {
      this.nota1 = nota1;
      this.nota2 = nota2;
    }

    public void CalcularFinal()
    {
      this.notaFinal = -1;
      if (this.nota1 >= 4 && this.nota2 >= 4)
      {
        Random notaFinal = new Random();
        this.notaFinal = notaFinal.Next(4, 10);
      }
    }

    public string Mostrar()
    {
      String alumno = string.Format("Legajo: {0}, Apellido: {1}, " +
        "Nombre: {2}, Nota 1: {3}, Nota 2: {4}, Nota Final: ", this.legajo,
        this.apellido, this.nombre, this.nota1, this.nota2);
      String notaFinal;
      CalcularFinal();
      if (this.notaFinal != -1)
      {
        notaFinal = string.Format("{0}", this.notaFinal);
      }
      else
      {
        notaFinal = "Alumno desaprobado";
      }
      alumno += notaFinal;
      return alumno;
    }
  }
}
