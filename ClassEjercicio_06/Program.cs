using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            String aux;
            int añoInicial;
            int añoFinal;
            int i;
            Console.WriteLine("Ingrese año inicial:");
            aux = Console.ReadLine();
            if (int.TryParse(aux, out añoInicial))
            {
                Console.WriteLine("Ingrese año final:");
                aux = Console.ReadLine();
                if (int.TryParse(aux, out añoFinal) && (añoFinal > añoInicial))
                {
                    Console.WriteLine("Años bisiestos entre {0} y {1}:", añoInicial, añoFinal);
                    for (i = añoInicial; i < añoFinal; i++)
                    {
                        if ((i % 4 == 0 && i % 100 != 0 || i % 400 == 0))
                        {
                            Console.WriteLine("{0}", i);
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Año final inválido");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Año inicial inválido");
                Console.ReadKey();
            }
        }
    }
}
