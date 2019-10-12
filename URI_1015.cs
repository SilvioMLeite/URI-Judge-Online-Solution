using System;
using System.Globalization;

namespace URI_1015_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            double x2 = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            double distancia1 = x1 - y1;
            double distancia2 = x2 - y2;

            double distancia = Math.Sqrt((Math.Pow(distancia1,2)) + (Math.Pow(distancia2,2)));

            Console.WriteLine(distancia.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
