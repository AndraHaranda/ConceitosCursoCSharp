using System;

namespace Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia" + 2021;
            string cursoProgramacao =
                @" -.NET -Java -JavaScript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursoProgramacao);


            Console.ReadLine();

        }
    }
}
