using System;

namespace Exercício_Validação_Informações
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Validadação Informações");

            bool validacaoNome = false;
            bool validacaoIdade = false;
            bool validacaoSalario = false;
            bool validacaoEstadoCivil = false;

            while (validacaoNome == false)
            {
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("O nome não pode ser vazio, tente novamente");
                }
                if (nome != "")
                {
                    validacaoNome = true;
                }
            }
            while (validacaoIdade == false)
            {
                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());

                if (idade > 0 && idade < 150)
                {
                    validacaoIdade = true;
                }
                if (idade < 0 || idade > 150)
                {
                    Console.WriteLine("Idade invalida, tente novamente");
                }
            }
            while (validacaoSalario == false)
            {
                Console.WriteLine("Digite seu salario");
                string salarioString = Console.ReadLine();
                
                if (salarioString == "")
                {
                    salarioString = "0";
                }

                float salario = float.Parse(salarioString);

                if (salario > 0)
                {
                    validacaoSalario = true;
                }
                if (salario <= 0)
                {
                    Console.WriteLine("Salário invalido, tente novamente");
                }
            }
            while (validacaoEstadoCivil == false)
            {
                Console.WriteLine("Digite seu estado civil; S para solteiro(a), C para casado(a), V para viuvo(a) e D para divorciado(a)");
                string estadoCivil = Console.ReadLine().ToUpper();

                if (estadoCivil == "S" || estadoCivil == "C" || estadoCivil == "V" || estadoCivil == "D")
                {
                    Console.WriteLine("Parabens todas as suas informações estão validadas");
                    validacaoEstadoCivil = true;
                }
                else
                {
                    Console.WriteLine("Estado civil invalido, tente novamente");
                }
            }
        }
    }
}
