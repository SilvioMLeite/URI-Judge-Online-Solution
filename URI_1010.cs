using System;
using System.Collections.Generic;
using System.Globalization;

namespace URI_1010_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pc1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(pc1[0]);
            int qtd1 = int.Parse(pc1[1]);
            double pre1 = double.Parse(pc1[2], CultureInfo.InvariantCulture);

            string[] pc2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(pc2[0]);
            int qtd2 = int.Parse(pc2[1]);
            double pre2 = double.Parse(pc2[2], CultureInfo.InvariantCulture);

            double total = (qtd1 * pre1) + (qtd2 * pre2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
