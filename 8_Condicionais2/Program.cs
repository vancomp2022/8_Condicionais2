// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais2");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = false;

            int idade = 68;
            bool ehIdoso = idade >= 65;

            Console.WriteLine(ehIdoso);

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                    Console.WriteLine("Nao pode entrar.");
             }

            Console.ReadLine();
        }
    }
}