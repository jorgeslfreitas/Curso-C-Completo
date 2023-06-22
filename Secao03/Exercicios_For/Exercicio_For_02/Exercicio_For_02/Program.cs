using System;

namespace Exercicio_For_02
{
    class Exercicio_02
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro para a quantidade de valores a serem digitados abaixo: ");
            int valor = int.Parse(Console.ReadLine());

            int contIn = 0;
            int contOut = 0;

            for(int i = 1; i <= valor; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valorX = int.Parse(Console.ReadLine());

                if(valorX >= 10 && valorX <= 20)
                {
                    contIn ++; 
                }
                else
                {
                    contOut ++;
                }
            }

            Console.WriteLine("{0} in", contIn);
            Console.WriteLine("{0} out", contOut);
        }
    }
}