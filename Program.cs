using System;

namespace console_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // usuário vai informar o que fazer e terá 3 opções
            // para cada opção vamos responder algo diferente
            // após escolher a opção

            string opcaoEscolhida;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Carro");
                Console.WriteLine("2 - Moto");
                Console.WriteLine("3 - Casar");
                Console.WriteLine("4 - Sair");
                Console.Write("\nEscolha uma opção: ");

                opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida)
                {
                    case "1": Console.WriteLine("Você escolheu carro"); break;
                    case "2": Console.WriteLine("Você escolheu moto"); break;
                    case "3": Console.WriteLine("Você escolheu casar"); break;
                    case "4": Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida"); break;
                }
                Console.ReadKey();
            } while (opcaoEscolhida != "4");
        }
    }
}
