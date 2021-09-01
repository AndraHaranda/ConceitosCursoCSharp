using System;

namespace ExercicioEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario <= 2800.00)
            {
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 142,00");
            }
            if (salario >= 2800.01)
            {
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 350,00");
            }
            else
            {
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 636,00");
            }

            Console.ReadLine();
        }
    }
}
