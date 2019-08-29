using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            String aux;
            int valorLimite;
            int i;
            int j;
            int suma1 = 0;
            int suma2 = 0;
            int centro = 2;
            List<int> centrosNumericos = new List<int>();
            Console.WriteLine("Ingrese valor:");
            aux = Console.ReadLine();
            if (int.TryParse(aux, out valorLimite))
            {
                Console.WriteLine("Centros Numéricos:");
                do
                {
                    for (i = 1; i < centro; i++)
                    {
                        suma1 += i;
                    }
                    for (j = centro + 1; suma1 > suma2; j++)
                    {
                        suma2 += j;
                    }
                    if (suma1 == suma2)
                    {
                        Console.WriteLine("{0}", centro);
                    }
                    centro++;
                    suma1 = 0;
                    suma2 = 0;
                }
                while (j < valorLimite);
                Console.ReadKey();
            }
        }
    }
}


