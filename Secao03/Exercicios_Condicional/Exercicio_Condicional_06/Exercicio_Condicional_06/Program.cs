﻿using System;
using System.Globalization;

namespace Exercicio_Condicional_06
{
    class Exercicio_06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.00)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.00)
            {
                Console.WriteLine("Intervalo (0 a 25)");
            }
            else if (valor <= 50.00)
            {
                Console.WriteLine("Intervalo (25 a 50)");
            }
            else if (valor <= 75.00)
            {
                Console.WriteLine("Intervalo (50 a 75)");
            }
            else
            {
                Console.WriteLine("Intervalo (75 a 100)");
            }
        }
    }
}
