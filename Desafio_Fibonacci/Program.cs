using System;

namespace Desafio_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");

            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;

            for (int i = 0; i < 15; i++)
            {
                fibonacci = numeroAtual + numeroAnterior;
                Console.WriteLine(fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }
        }
    }
}
