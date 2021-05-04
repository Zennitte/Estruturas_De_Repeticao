using System;

namespace Exercício_Nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classificidador de Categoria");

            string novaVerificacao = "s";

            do
            {
                Console.WriteLine("Escreva sua idade");
                int idadeNadador = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (idadeNadador >= 5 && idadeNadador <= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sua categoria é infantil A");
                }
                if (idadeNadador >= 8 && idadeNadador <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sua categoria é infantil B");
                }
                if (idadeNadador >= 11 && idadeNadador <= 13)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sua categoria é juvenil A");
                }
                if (idadeNadador >= 14 && idadeNadador <= 17)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sua categoria é juvenil B");
                }
                if (idadeNadador >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Não existe categoria para sua faixa etária");
                }

                if (idadeNadador < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Não existe categoria para sua faixa etária");
                }

                Console.WriteLine("Deseja fazer uma nova verificação: S/N");
                novaVerificacao = Console.ReadLine().ToLower();

                if (novaVerificacao == "n")
                {
                    Console.WriteLine("Adios");
                }

            } while (novaVerificacao == "s");
        }
    }
}
