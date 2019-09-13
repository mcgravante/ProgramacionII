using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ej_27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosRandom = new List<int>();
            Random numeroRandom = new Random();

            for (int i = 0; i < 20; i++)
            {
                int aux = numeroRandom.Next(-1000000, 1000000);
                if (aux != 0)
                {
                    numerosRandom.Add(aux);
                }
            }
            foreach (int numero in numerosRandom)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");


            List<int> numerosPositivos = new List<int>();
            foreach (int numero in numerosRandom)
            {
                if (numero > 0)
                {
                    numerosPositivos.Add(numero);
                }
            }
            numerosPositivos.Sort();
            numerosPositivos.Reverse();


            foreach (int numero in numerosPositivos)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");

            List<int> numerosNegativos = new List<int>();

            foreach (int numero in numerosRandom)
            {
                if (numero < 0)
                {
                    numerosNegativos.Add(numero);
                }
            }
            numerosNegativos.Sort();

            foreach (int numero in numerosNegativos)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();



            Queue queue = new Queue();
            Random numeroRandom2 = new Random();

            for (int i = 0; i < 20; i++)
            {
                int aux = numeroRandom2.Next(-1000000, 1000000);
                if (aux != 0)
                {
                    queue.Enqueue(aux);
                }
            }
            foreach (int numero in queue)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");


            Queue queuePos = new Queue();
            List<int> listaParaQueue = new List<int>();
            foreach (int numero in queue)
            {
                if (numero > 0)
                {
                    listaParaQueue.Add(numero);
                }
            }
            listaParaQueue.Sort();
            listaParaQueue.Reverse();
            foreach (int numParaQueue in listaParaQueue)
            {
                queuePos.Enqueue(numParaQueue);
            }


            foreach (int numero in queuePos)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");

            Queue queueNeg = new Queue();

            List<int> listaParaQueue2 = new List<int>();
            foreach (int numero in queue)
            {
                if (numero < 0)
                {
                    listaParaQueue2.Add(numero);
                }
            }
            listaParaQueue2.Sort();
            foreach (int numParaQueue in listaParaQueue2)
            {
                queueNeg.Enqueue(numParaQueue);
            }


            foreach (int numero in queueNeg)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");

            Stack stack = new Stack();
            Random numeroRandom3 = new Random();

            for (int i = 0; i < 20; i++)
            {
                int aux = numeroRandom3.Next(-1000000, 1000000);
                if (aux != 0)
                {
                    stack.Push(aux);
                }
            }
            foreach (int numero in stack)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");


            Stack stackPos = new Stack();
            List<int> listaParaStackPos = new List<int>();
            foreach (int numero in stack)
            {
                if (numero > 0)
                {
                    listaParaStackPos.Add(numero);
                }
            }
            listaParaStackPos.Sort();
            foreach (int numParaQueue in listaParaStackPos)
            {
                stackPos.Push(numParaQueue);
            }


            foreach (int numero in stackPos)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");

            Stack stackNeg = new Stack();

            List<int> listaParaStackNeg = new List<int>();
            foreach (int numero in stack)
            {
                if (numero < 0)
                {
                    listaParaStackNeg.Add(numero);
                }
            }
            listaParaStackNeg.Sort();
            listaParaStackNeg.Reverse();

            foreach (int numParaQueue in listaParaStackNeg)
            {
                stackNeg.Push(numParaQueue);
            }


            foreach (int numero in stackNeg)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("------------------------------------------");
        }
    }
}
