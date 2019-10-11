using System;
using System.Globalization;

namespace URI_1008_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double salaryPerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salary = hours * salaryPerHour;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
