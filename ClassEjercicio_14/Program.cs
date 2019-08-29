using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_14
{
  class Program
  {
    static void Main(string[] args)
    {
      int opcion;
      double lado;
      double b;
      double h;
      double r;
      double area = 0;
      bool valorValido = false;
      Console.WriteLine("Ingrese opcion 1 para cuadrado, 2 para triangulo y 3 para circulo:");
      if (int.TryParse(Console.ReadLine(), out opcion))
      {
        switch (opcion)
        {
          case 1:
            Console.WriteLine("Ingrese valor del lado:");
            if (double.TryParse(Console.ReadLine(), out lado))
            {
              area = CalculoDeArea.CalcularCuadrado(lado);
              valorValido = true;
            }
            break;

          case 2:
            Console.WriteLine("Ingrese valor de la base:");
            if (double.TryParse(Console.ReadLine(), out b))
            {
              Console.WriteLine("Ingrese valor de la altura:");
              if (double.TryParse(Console.ReadLine(), out h))
              {
                area = CalculoDeArea.CalcularTriangulo(b, h);
                valorValido = true;
              }
            }
            break;

          case 3:
            Console.WriteLine("Ingrese valor del radio:");
            if (double.TryParse(Console.ReadLine(), out r))
            {
              area = CalculoDeArea.CalcularCirculo(r);
              valorValido = true;
            }
            break;

          default:
            break;
        }
        if (valorValido)
        {
          Console.WriteLine("Área: {0}", area);
          Console.ReadKey();
        }
        else
        {
          Console.WriteLine("Valor Inválido");
          Console.ReadKey();
        }
      }
    }
  }
}
