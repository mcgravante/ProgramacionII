using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_07
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime localDate = DateTime.Now;

      int dateNow = localDate.Day;
      int monthNow = localDate.Month;
      int yearNow = localDate.Year;
      int birthDay;
      int birthMonth;
      int birthYear;
      int diasAcumulados = 0;
      Boolean esBisiesto = false;
      Boolean tiene30 = false;
      Boolean tiene28 = false;
      int j;
      String aux;
      Console.WriteLine("Ingrese año de nacimiento:");
      aux = Console.ReadLine();
      if (int.TryParse(aux, out birthYear) && birthYear <= 2019 && birthYear >= 1900)
      {
        if ((birthYear % 4 == 0 && birthYear % 100 != 0 || birthYear % 400 == 0))
        {
          esBisiesto = true;
        }
        Console.WriteLine("Ingrese mes de nacimiento:");
        aux = Console.ReadLine();
        if (int.TryParse(aux, out birthMonth) && birthMonth <= 12 && birthMonth >= 1)
        {
          if (birthMonth == 2)
          {
            tiene28 = true;
          }
          else if (birthMonth == 4 || birthMonth == 6 || birthMonth == 9 || birthMonth == 11)
          {
            tiene30 = true;
          }
          Console.WriteLine("Ingrese fecha de nacimiento:");
          aux = Console.ReadLine();
          if (tiene28)
          {
            if (esBisiesto)
            {
              if (!(int.TryParse(aux, out birthDay) && birthDay <= 29 && birthMonth >= 1))
              {
                Console.WriteLine("Ingrese fecha válida");
                Console.ReadKey();
                return;
              }

            }
            else
            {
              if (!(int.TryParse(aux, out birthDay) && birthDay <= 28 && birthMonth >= 1))
              {
                Console.WriteLine("Ingrese fecha válida");
                Console.ReadKey();
                return;
              }
            }
          }
          else if (tiene30)
          {
            if (!(int.TryParse(aux, out birthDay) && birthDay <= 30 && birthMonth >= 1))
            {
              Console.WriteLine("Ingrese fecha válida");
              Console.ReadKey();
              return;
            }
          }
          else
          {
            if (!(int.TryParse(aux, out birthDay) && birthDay <= 31 && birthMonth >= 1))
            {
              Console.WriteLine("Ingrese fecha válida");
              Console.ReadKey();
              return;
            }

          }

          for (int i = birthYear; i <= yearNow; i++)
          {
            if (i == birthYear)
            {
              if (birthYear == yearNow)
              {
                for (j = birthMonth; j < monthNow; j++)
                {
                  diasAcumulados += DateTime.DaysInMonth(i, j);
                }
                diasAcumulados -= birthDay;
                diasAcumulados += dateNow;
              }
              else
              {
                for (j = birthMonth; j <= 12; j++)
                {
                  diasAcumulados += DateTime.DaysInMonth(i, j);
                }
              }
            }
            else if (i < birthYear && i < yearNow)
            {
              for (j = 1; j <= 12; j++)
              {
                diasAcumulados += DateTime.DaysInMonth(i, j);
              }
            }
            else if (i == yearNow && birthYear != yearNow)
            {
              for (j = 1; j < monthNow; j++)
              {
                diasAcumulados += DateTime.DaysInMonth(i, j);
              }
            }
          }

          Console.WriteLine("dias transcurridos: {0}", diasAcumulados);

        }
        else
        {
          Console.WriteLine("Ingrese mes válido");
          Console.ReadKey();
          return;
        }
      }
      else
      {
        Console.WriteLine("Ingrese año válido");
        Console.ReadKey();
        return;
      }
      Console.ReadKey();
    }
  }
}
