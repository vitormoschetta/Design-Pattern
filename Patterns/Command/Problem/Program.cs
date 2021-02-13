using System;
using Problem.Commands;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Options();
        }

        static void Options()
        {
            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("Digite '1' para Andar");
            Console.WriteLine("Digite '2' para Correr");
            string option = Console.ReadLine();

            Execute(option);
        }

        static void Execute(string option)
        {
            if (option == "1")
                Operation.ExecuteAndar();
            else if (option == "2")
                Operation.ExecuteCorrer();
            else {
                Console.WriteLine("Opção inválida!");
                Options();
            }
                
        }
    }


    public class Operation
    {
        public static void ExecuteAndar()
        {
            var andar = new Andar();
            andar.ExecuteAndar();
        }

        public static void ExecuteCorrer()
        {
            var correr = new Correr();
            correr.ExecuteCorrer();
        }


    }
}
