using System;
using Pattern.Commands;
using Pattern.Interfaces;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {            
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Digite o seu nome abaixo: ");
            string userName = Console.ReadLine();            

            if (string.IsNullOrEmpty(userName)) {
                Console.WriteLine("Nome não informado!");
                Start();
            }                
            else
                Options(userName);
        }

        static void Options(string userName)
        {                        
            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("Digite '1' para Andar");
            Console.WriteLine("Digite '2' para Correr");
            string option = Console.ReadLine();

            Execute(userName,option);
        }

        static void Execute(string userName, string option)
        {
            if (option == "1")
                Operation.Execute(new AndarCommand(userName));
            else if (option == "2")
                Operation.Execute(new CorrerCommand(userName));
            else {
                Console.WriteLine("Opção inválida!");
                Options(userName);
            }
                
        }

    }



    public class Operation
    {
        public static void Execute(ICommand command)
        {
            command.Execute();
        }

    }
}
