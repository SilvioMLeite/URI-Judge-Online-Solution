using System;

namespace URI_1020_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ano = 365;
            const int mes = 30;

            int idadeEmDias = int.Parse(Console.ReadLine());

            int anos = idadeEmDias / ano;
            int meses = (idadeEmDias % ano) / mes;
            int dias = idadeEmDias % ano % mes;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
