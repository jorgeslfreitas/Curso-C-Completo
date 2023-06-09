using System;

namespace Exercicio_Condicional_01
{
    class Exercicio_01
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Não Negativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}