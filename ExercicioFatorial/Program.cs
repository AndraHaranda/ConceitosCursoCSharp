using System;

namespace ExercicioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 2;

            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine(fatorial);
            }
            Console.ReadLine();
        }
    }
}
