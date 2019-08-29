using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1EjerciciosGravante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;
            Double suma = 0.0;
            String aux;
            Double promedio = 0.0;
            int valor = 0;
            Console.WriteLine("Ingrese 5 valores");

            for (int i = 0; i < 5; i++)
            {
                aux = Console.ReadLine();
                if (int.TryParse(aux, out valor))
                {
                    if (valorMaximo < valor)
                    {
                        valorMaximo = valor;
                    }
                    if (valorMinimo > valor)
                    {
                        valorMinimo = valor;
                    }
                    suma += valor;
                }
                else
                {
                    i--;
                }
            }
            promedio = suma / 5;
            Console.Write("Valor Maximo = {0} Valor Minimo = {1}  Promedio = {2:#,###.00}", valorMaximo, valorMinimo, promedio);
            Console.ReadKey();
        }
    }
}
