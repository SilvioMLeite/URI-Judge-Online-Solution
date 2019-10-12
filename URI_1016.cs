using System;

namespace URI_1016_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = 60;
            
            int distancia = int.Parse(Console.ReadLine());

            int tempo  = hora * distancia / 30;

            Console.WriteLine(tempo + " minutos");
        }
    }
}
