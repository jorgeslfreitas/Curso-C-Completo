using System;

namespace Exercicio_For_06
{
    class Exercicio_06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro pra cálculo dos seus divisores");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    int div = num / i;
                    Console.WriteLine(div);
                }
            }
        }
    }
}