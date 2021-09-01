using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int idadeAndra = 21;
            int qtdePessoas = 2;

            int idadeAndra = 5;
            int qtdePessoas = 10;

            int idadeAndra = 5;
            int qtdePessoas = 2;

            if (idadeAndra >= 18)
            {
                Console.WriteLine("Andra possui idade superior a 18 anos");
            }
            else
            {
                if (qtdePessoas >= 5)
                {
                    Console.WriteLine("O limite de pessoas excedeu");
                }
                else
                {
                    Console.WriteLine("Andra não possui idade superior a 18 anos");
                }
            }

            Console.ReadLine();
            */

            //-------------- CÓDIGO MELHORADO
            int idadeAndra = 18;
            int qtdePessoas = 3;

            bool acompanhado = qtdePessoas <= 5;

            if (idadeAndra >= 18 && acompanhado == true)
            {
                Console.WriteLine("Andra pode entrar");
            }
            else
            {
                Console.WriteLine("Andra não pode entrar");
            }
        }
    }
}
