using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            int cont = 1;

            /*valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 2 meses, você terá R$" + valorInvestido);
            */

            while (cont <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + cont + " meses, você terá R$" + valorInvestido);

                // cont = cont + 1;

                cont ++; 
            }
            Console.ReadLine();
        }
    }
}
/* é possivel fazer a mesma coisa usando o FOR 

for (int i = 0; i < length; i++)
{

}
*/