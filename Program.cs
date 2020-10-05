using System;

namespace atividade_cris
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            int n;
            for (n = 1; n <= 10; n++)
            {
                fatorial *= n;
                Console.WriteLine($"{n} fatorial = {fatorial} ");
            };
           
        }
    }
}
