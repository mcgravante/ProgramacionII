using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassEjercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            String aux;
            int valor = 0;
            Console.WriteLine("Ingrese valor");
            aux = Console.ReadLine();
            if (int.TryParse(aux, out valor))
            {
                if (valor > 0)
                {
                    Console.WriteLine("Cuadrado: {0}", Math.Pow(valor, 2));
                    Console.WriteLine("Cubo: {0}", Math.Pow(valor, 3));
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                Console.ReadKey();
            }
        }
    }
}

