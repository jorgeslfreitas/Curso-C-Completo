using System;

namespace Exercicio_Condicional_03
{

    class Exercicio_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}