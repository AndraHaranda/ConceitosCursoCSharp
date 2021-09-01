using System;

namespace TiposDeVariaveis

{
    class Program
    {
        static void Main(string[] args)
        {
            Double Salario = 1720.00;
            Double Soma, Divisao, Multiplicacao, Subtracao;

            Soma = Salario + 100.00;

            Divisao = Salario / 2;

            Multiplicacao = Salario * 3;

            Subtracao = Salario - 3;

            Console.WriteLine(Salario);
            Console.WriteLine(Soma);
            Console.WriteLine(Divisao);
            Console.WriteLine(Multiplicacao);
            Console.WriteLine(Subtracao);

        }
    }
}
