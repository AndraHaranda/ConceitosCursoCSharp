using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeAndra = 21;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Andra está acompanhado";
            }

            //Else quando tiver somente uma linha não é obrigatorio o uso de {}
            else
                mensagemAdicional = "Andra não está acompanhado";
            

            if (idadeAndra >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

        }
    }
}
