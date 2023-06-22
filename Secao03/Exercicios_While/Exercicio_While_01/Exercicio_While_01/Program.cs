using System;
using System.Globalization;

namespace Exercicio_While_01
{
    class Exercicio_01
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            Console.Write("Digite a senha: ");
            int digitado = int.Parse(Console.ReadLine());

            while (digitado != senha)
            {
                Console.WriteLine("Senha inválida");
                digitado = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}