using System;

namespace ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******


            for (int contLinha = 0; contLinha < 10; contLinha++)
            {
                for (int contColuna = 0; contColuna <= contLinha; contColuna++)
                {
                    Console.Write("*");
                   /* if (contColuna >= contLinha)
                        break;
                   */
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
