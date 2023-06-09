using System;

namespace Exercicio_Condicional_04
{
    class Exercicio_04
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracaoJogo;

            Console.WriteLine("Digite a hora inicial e hora final de um jogo: ");
            string[] horas = Console.ReadLine().Split(" ");
            horaInicial = int.Parse(horas[0]);
            horaFinal = int.Parse(horas[1]);

            if(horaInicial < horaFinal)
            {
                duracaoJogo = horaFinal - horaInicial;
            }
            else
            {
                duracaoJogo = (24 - horaInicial) + horaFinal;
            }

            Console.WriteLine(duracaoJogo);

            if(duracaoJogo >= 1 && duracaoJogo <= 24)
            {
                Console.WriteLine($"O jogo durou {duracaoJogo} hora(s)");
            }
            else
            {
                Console.WriteLine("Valores de entradas inválidos!");
            }
        }
    }
}