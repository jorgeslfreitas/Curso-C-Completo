using System;
using System.Globalization;

namespace Exercicio_Condicional_05
{
    class Exercicio_05
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.WriteLine("Digite o código e a quantidade deste item: ");
            string[] produto = Console.ReadLine().Split(" ");
            int codigo = int.Parse(produto[0]);
            int quantidade = int.Parse(produto[1]);

            if (codigo >= 1 && codigo <= 5)
            {

                if (codigo == 1)
                {
                    total = quantidade * 4.00;
                }
                else if (codigo == 2)
                {
                    total = quantidade * 4.50;
                }
                else if (codigo == 3)
                {
                    total = quantidade * 5.00;
                }
                else if (codigo == 4)
                {
                    total = quantidade * 2.00;
                }
                else if (codigo == 5)
                {
                    total = quantidade * 1.50;
                }
             
                Console.WriteLine("Total: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Código inválido");
            }


        }
    }
}