using System;
using System.Globalization;

namespace URI_1017_Solution
{
    class Program
    {
        static void Main(string[] args)
        {

            const double qtdLtHr = 12.0;

            int tempo = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            double totallitros = tempo * velocidadeMedia / qtdLtHr;

            Console.WriteLine(totallitros.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
