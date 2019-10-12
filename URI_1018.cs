using System;

namespace URI_1018_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
         
           int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n);
            Console.WriteLine(n / 100 + " nota(s) de R$ 100,00");
            n %= 100;
            Console.WriteLine(n / 50 + " nota(s) de R$ 50,00");
            n %= 50;
            Console.WriteLine(n / 20 + " nota(s) de R$ 20,00");
            n %= 20;
            Console.WriteLine(n / 10 + " nota(s) de R$ 10,00");
            n %= 10;
            Console.WriteLine(n / 5 + " nota(s) de R$ 5,00");
            n %= 5;
            Console.WriteLine(n / 2 + " nota(s) de R$ 2,00");
            n %= 2;
            Console.WriteLine(n + " nota(s) de R$ 1,00");
        }
    }
}
