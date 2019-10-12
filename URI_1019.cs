using System;

namespace URI_1019_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            const int qtdSegHr = 3600;
            const int qtdSegMn = 60;

            int tempo = int.Parse(Console.ReadLine());

            int hora = tempo / qtdSegHr;
            int minutos = (tempo % qtdSegHr) / qtdSegMn;
            int segundos = tempo % qtdSegMn;

            Console.WriteLine(hora + ":" + minutos + ":" + segundos);
        }
    }
}
