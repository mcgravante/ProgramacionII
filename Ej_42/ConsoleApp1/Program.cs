using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiClase;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase.MiClase clase = new MiClase.MiClase(2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();

        }
    }
}
