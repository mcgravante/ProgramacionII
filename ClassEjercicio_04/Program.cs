using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean esDivisor = false;
            int cantNumPerf = 0;
            for (int i = 2; cantNumPerf < 5; i++)
            {
                int sumaDeDivisores = 0;
                for (int j = 1; j < i; j++)
                {
                    esDivisor = true;
                    if (i % j != 0)
                    {
                        esDivisor = false;
                    }
                    if (esDivisor == true)
                    {
                        sumaDeDivisores += j;
                    }
                }
                if (sumaDeDivisores == i)
                {
                    cantNumPerf++;
                    Console.WriteLine("Este numero es perfecto: {0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}

