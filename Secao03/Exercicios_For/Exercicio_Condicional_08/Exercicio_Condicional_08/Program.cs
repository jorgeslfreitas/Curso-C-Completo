using System;
using System.Globalization;

namespace Exercicio_Condicional_08
{
    class Exercicio_08
    {
        static void Main(string[] args)
        {
            double imposto;

            Console.Write("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00)
            {
                imposto = salario * 0.08;
                Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500.00)
            {
                imposto = 1000 * 0.08;
                imposto = imposto + (salario - 3000.00) * 0.18;
                Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imposto = 1000 * 0.08;
                imposto = imposto + 1500 * 0.18;
                imposto = imposto + (salario - 4500.00) * 0.28;
                Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}