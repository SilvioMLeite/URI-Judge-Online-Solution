using System;
using System.Globalization;

namespace URI_1012_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = a * c / 2.0;
            double circulo = PI * Math.Pow(c, 2.0);
            double trapezio = (a + b) * c / 2.0;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3",CultureInfo.InvariantCulture ));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3",CultureInfo.InvariantCulture));

        }
    }
}
