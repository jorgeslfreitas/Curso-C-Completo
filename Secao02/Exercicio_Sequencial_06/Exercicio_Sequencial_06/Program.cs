using System;
using System.Globalization;

namespace Exercicio_Sequencial_06
{
    class Exercicio_06
    {
        static void Main(string[] args)


        {
            double a, b, c, areaTriangulo, raioCirculo, trapezio, areaQuadrado, areaRetangulo;
            Console.WriteLine("Digite 3 valores");
            string[] valores = Console.ReadLine().Split(" ");
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTriangulo = (a * c) / 2;
            raioCirculo = Math.PI * Math.Pow(c, 2);
            trapezio = ((a + b) * c) / 2;
            areaQuadrado = Math.Pow(b, 2);
            areaRetangulo = a * b;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Triângulo: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + raioCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}