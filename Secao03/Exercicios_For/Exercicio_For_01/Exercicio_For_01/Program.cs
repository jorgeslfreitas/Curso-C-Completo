using System;

namespace Exercicio_For_01
{
    class Exercicio_01
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            for(int i = 0; i <= valor; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}