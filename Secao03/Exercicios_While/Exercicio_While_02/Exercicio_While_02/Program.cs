using System;

namespace Exercicio_While_02
{
    class Exercicio_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X e Y:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}