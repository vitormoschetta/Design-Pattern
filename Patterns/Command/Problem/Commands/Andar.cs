using System;

namespace Problem.Commands
{
    public class Andar
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Andar";

        public void ExecuteAndar()
        {
            Console.WriteLine(Id.ToString() + " " + Name);
        }
    }
}