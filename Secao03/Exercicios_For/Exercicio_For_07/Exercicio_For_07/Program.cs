using System;

namespace Exercicio_For_07
{
    class Exercicio_07
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                double quadrado = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);

                Console.WriteLine($"{i} {quadrado} {cubo}");
                
            }
        }
    }
}