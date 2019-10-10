using System;

namespace URI_1007_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[4];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            int A = vet[0];
            int B = vet[1];
            int C = vet[2];
            int D = vet[3];

            int DIFERENCA = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
