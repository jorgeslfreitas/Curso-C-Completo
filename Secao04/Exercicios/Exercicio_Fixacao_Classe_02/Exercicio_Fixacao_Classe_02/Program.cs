using System;
using System.Globalization;

namespace Exercicio_Fixacao_Classe_02
{
    class Exercicio_Fixacao_02
    {
        static void Main(string[] args)
        {
            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            double salarioMedio;

            Console.Write("Digite o nome e salário do primeiro funcinário: ");
            string[] vetFunc1 = Console.ReadLine().Split(" ");
            Console.Write("Digite o nome e salário do segundo funcionário: ");
            string[] vetFunc2 = Console.ReadLine().Split(" ");

            func1.Nome = vetFunc1[0];
            func1.Salario = double.Parse(vetFunc1[1], CultureInfo.InvariantCulture);

            func2.Nome = vetFunc2[0];
            func2.Salario = double.Parse(vetFunc2[1], CultureInfo.InvariantCulture);

            salarioMedio = (func1.Salario + func2.Salario) / 2;

            Console.Write("Salário médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
