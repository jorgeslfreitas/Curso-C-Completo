using System;
using System.Globalization;

namespace Exercicio_Fixacao_02
{
    class Exercicio_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            int quantidadeQuatos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');

            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quantidadeQuatos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));  

        }
    }
}