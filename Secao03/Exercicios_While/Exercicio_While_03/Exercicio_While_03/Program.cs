using System;

namespace Exercicio_While_03
{
    class Exercicio_03
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            Console.WriteLine("Digite o código do seu produto de preferência: ");
            Console.WriteLine("1. Alcool, 2. Gasolina, 3. Diesel e 4. Fim");
            int codigo = int.Parse(Console.ReadLine());

            while(codigo != 4)
            {
                Console.WriteLine("Digite o código do seu produto de preferência: ");
                Console.WriteLine("1. Alcool, 2. Gasolina, 3. Diesel e 4. Fim");
                codigo = int.Parse(Console.ReadLine());

                if(codigo == 1)
                {
                    alcool++;
                }
                else if(codigo == 2)
                {
                    gasolina++;
                }
                else if(codigo == 3)
                {
                    diesel++;
                }
                else if(codigo == 4)
                {
                    Console.WriteLine("Muito Obrigado");
                }
            }

            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}