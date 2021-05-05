using System;

namespace Exercício_Senha_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Usuario e Senha \n");

            bool verificacao = false;


            while (verificacao == false)
            {
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();

                if (senha == nome)
                {
                    Console.WriteLine("A senha não pode ser igual ao nome, tente novamente");
                }if (senha != nome)
                {
                    Console.WriteLine("Usuario cadastrado");
                    verificacao = true;
                }

            }
        }
    }
}
