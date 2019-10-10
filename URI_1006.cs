using System;
using System.Globalization;

namespace URI_1006_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 2.00) + (B * 3.00) + (C * 5.00)) / ( 2 + 3 + 5);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
