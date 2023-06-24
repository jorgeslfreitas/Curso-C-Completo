using System;
using System.Globalization;

namespace Exercicio_For_04
{
    class Exercicio_04
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para repetição: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Digite um numerador e um denominador:");
                int numerador = int.Parse(Console.ReadLine());
                int denominador = int.Parse(Console.ReadLine());

                if(denominador != 0)
                {
                    double divisao = (double)numerador / denominador;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão impossível!");
                }
            }
        }
    }
}
