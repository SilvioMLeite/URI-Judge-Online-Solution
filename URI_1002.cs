using System;
using System.Globalization;

namespace URI_1002_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = 3.14159;

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = N * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
