using System;
using System.Globalization;

namespace URI_1009_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double totalSales = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double total = salary + (totalSales * 0.15);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
