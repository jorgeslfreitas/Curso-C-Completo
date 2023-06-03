using System;
using System.Globalization;

namespace Exercicio_Sequencial_04
{
    class Exercicio_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número do funcionário:");
            int numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de horas trabalhadas:");
            double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor por hora trabalhada:");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"Número: {numFuncionario}");
            Console.WriteLine("Salário: R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
