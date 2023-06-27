using System;

namespace Exercicio_Fixacao_Classe_01
{
    class Exercicio_Fixacao_01
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.Write("Digite nome e idade da primeira pessoa: ");
            string[] vetPessoa1 = Console.ReadLine().Split(" ");
            Console.Write("Digite nome e idade da segunda pessoa: ");
            string[] vetPessoa2 = Console.ReadLine().Split(" ");

            pessoa1.Nome = vetPessoa1[0];
            pessoa1.Idade = int.Parse(vetPessoa1[1]);

            pessoa2.Nome = vetPessoa2[0];
            pessoa2.Idade = int.Parse(vetPessoa2[1]);

            if(pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha {pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }
        }
    }
}
