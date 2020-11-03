using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("Quantos valores você quer? ");
            int quantosValores = int.Parse(Console.ReadLine());

            for ( int i = 0; i < quantosValores; i++)
            {
                Console.Write("Digite o valor: ");
                int valorX = int.Parse(Console.ReadLine());
                printService.AddValor(valorX);
            }

            printService.Print();
            Console.WriteLine();
            Console.WriteLine("Primeiro digitado: " + printService.Primeiro());

            Console.ReadKey();
        }
    }
}
