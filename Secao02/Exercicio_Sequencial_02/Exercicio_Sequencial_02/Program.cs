using System;
using System.Globalization;

namespace Exercicio_Sequencial_02
{
    class Exercicio_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double area = Math.PI * (Math.Pow(raio, 2));

            Console.WriteLine("Área: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
