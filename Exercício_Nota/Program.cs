using System;

namespace Exercício_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Idade");

            bool respostaCorreta = false;

            while (respostaCorreta == false)
            {
                Console.WriteLine("Digite um número de 0 a 10");
                string resposta = Console.ReadLine();

                if (resposta == "7")
                {
                    Console.WriteLine("Parabéns você acertou o número");
                    respostaCorreta = true;
                } else
                {
                    Console.WriteLine("Você não acertou o número tente novamente");
                }
            }
        }
    }
}
