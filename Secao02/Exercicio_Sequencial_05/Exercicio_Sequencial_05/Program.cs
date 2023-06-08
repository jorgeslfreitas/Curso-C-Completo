using System;
using System.Globalization;

namespace Exercicio_Sequencial_05
{
    class Exercicio_05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código da peça 1, número de peças, valor unitário de cada peça: ");
            string [] vet1 = Console.ReadLine().Split(" ");
            Console.WriteLine("Digite o código da peça 2, número de peças, valor unitário de cada peça: ");
            string[] vet2 = Console.ReadLine().Split(" ");

            int codPeca1 = int.Parse(vet1[0]);
            int numPeca1 = int.Parse(vet1[1]);
            double valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            int codPeca2 = int.Parse(vet2[0]);
            int numPeca2 = int.Parse(vet2[1]);
            double valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double totalPagar = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);

            Console.WriteLine("Valor a pagar: R$" + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
