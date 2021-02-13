using System;

namespace Problem.Commands
{
    public class Correr
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Correr";

        public void ExecuteCorrer()
        {
            Console.WriteLine(Id.ToString() + " " + Name);
        }
    }
}