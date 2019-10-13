using System;
using System.Globalization;

namespace UriJudge_Online_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, E;
            int N, a, b, c, d, e, f, g, h, i, j, k, l, B, m, n, o, p, q, r, s, t, u;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            N = (int)A;

            a = N / 100;
            b = N % 100;
            c = b / 50;
            d = b % 50;
            e = d / 20;
            f = d % 20;
            g = f / 10;
            h = f % 10;
            i = h / 5;
            j = h % 5;
            k = j / 2;
            l = j % 2;

            E = A * 100;
            B = (int)E;

            m = B % 100;
            n = m / 50;
            o = m % 50;
            p = o / 25;
            q = o % 25;
            r = q / 10;
            s = q % 10;
            t = s / 5;
            u = s % 5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(a + " nota(s) de R$ 100.00");
            Console.WriteLine(c + " nota(s) de R$ 50.00");
            Console.WriteLine(e + " nota(s) de R$ 20.00");
            Console.WriteLine(g + " nota(s) de R$ 10.00");
            Console.WriteLine(i + " nota(s) de R$ 5.00");
            Console.WriteLine(k + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(l + " moeda(s) de R$ 1.00");
            Console.WriteLine(n + " moeda(s) de R$ 0.50");
            Console.WriteLine(p + " moeda(s) de R$ 0.25");
            Console.WriteLine(r + " moeda(s) de R$ 0.10");
            Console.WriteLine(t + " moeda(s) de R$ 0.05");
            Console.WriteLine(u + " moeda(s) de R$ 0.01");
        }

    }
}
