using System;

namespace URI_1013_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            int valor3 = int.Parse(valores[2]);

            int maiorAB = (valor1 + valor2 + Math.Abs(valor1 - valor2)) / 2;
            int maior = (maiorAB + valor3 + Math.Abs(maiorAB - valor3)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}