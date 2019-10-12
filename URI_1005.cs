using System;
using System.Globalization;

namespace URI_1005_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = ((nota1 * 3.5) + (nota2 * 7.5)) / 11 ;

            Console.WriteLine("MEDIA = " + media.ToString("F5",CultureInfo.InvariantCulture));
        }
    }
}
