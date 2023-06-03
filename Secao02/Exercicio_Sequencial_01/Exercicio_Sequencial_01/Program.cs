using System;

namespace Exercicio_Sequencial_01
{
    class Exercicio_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma\r\nmensagem explicativa, conforme exemplos.");
            Console.WriteLine("Valor 1:");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            double valor2 = double.Parse(Console.ReadLine());

            double soma = valor1 + valor2;

            Console.WriteLine($"Soma: {soma}");
        }
    }
}