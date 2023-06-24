using System;

namespace Exercicio_For_05
{
    class Exercicio_05
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                fatorial = fatorial * (num - i);
            }

            Console.WriteLine(fatorial);
        }
    }
}
