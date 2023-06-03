using System;
using System.Globalization;

namespace Exercicio_Sequencial_03
{
    class Exercicio_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor 1:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 3:");
            int valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 4:");
            int valor4 = int.Parse(Console.ReadLine());

            int produto = (valor1 * valor2) - (valor3 * valor4);

            Console.WriteLine($"Diferença: {produto}");
        }
    }
}
