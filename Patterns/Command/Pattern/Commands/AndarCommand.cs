using System;
using Pattern.Interfaces;

namespace Pattern.Commands
{
    public class AndarCommand : ICommand
    {
        public AndarCommand(string userName)
        {
            UserName = userName;
        }        
        
        public string UserName { get; private set; }


        public void Execute()
        {
            Console.WriteLine(UserName + " está andando...");
        }
    }
}