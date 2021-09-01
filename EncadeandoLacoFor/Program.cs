using System;

namespace EncadeandoLacoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contratoAno = 1; contratoAno <= 5; contratoAno++)
            {
                for (int contatorMes = 1; contatorMes <= 12; contatorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao termino do investimento, você terá R$ " + valorInvestido);
            Console.ReadLine();
        }
    }
}
