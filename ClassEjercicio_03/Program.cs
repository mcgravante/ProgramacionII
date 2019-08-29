using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            String aux;
            int valorLimite;
            int i;
            int j;
            Console.WriteLine("Ingrese valor:");
            aux = Console.ReadLine();
            if (int.TryParse(aux, out valorLimite))
            {
                for (i = 2; i <= valorLimite; i++)
                {
                    for (j = 2; j < i; j++)

                    {
                        if (i % j == 0)
                        {
                            break;
                        }

                    }
                    if (i==j)
                    {
                        Console.WriteLine("Este numero es primo: {0}", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
