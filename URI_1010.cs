using System;
using System.Collections.Generic;
using System.Globalization;

namespace URI_1010_Solution
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] mat = new double[2, 3];
            double[] qtds = new double[2];
            double[] subtotal = new double[2];

            for ( int i = 0; i <= 1; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j <= 2; j++)
                {
                    mat[i, j] = double.Parse(valores[j],CultureInfo.InvariantCulture);
                    
                }

                qtds[i] =  mat[i,1];
                subtotal[i] = mat[i,2];
                
            }

            double total = (qtds[0] * subtotal[0]) + (qtds[1] * subtotal[1]);


            Console.WriteLine("TOTAL A PAGAR R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
