using System;
using System.Globalization;

namespace Exercicio_For_03
{
    class Exercicio_03
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de casos de testes: ");
            int casosTestes = int.Parse(Console.ReadLine());

            for(int i = 0; i < casosTestes; i++)
            {
                Console.WriteLine("Digite 3 valores com casa decimal:");
                double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double mediaPonderada = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;

                Console.WriteLine(mediaPonderada.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
