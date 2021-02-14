using System;
using Pattern.Interfaces;
using Pattern.Models;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = args.Length > 0 ? args[0].ToUpper() : null;

            ISwitchable lamp = new Light();
            
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);
            
            Switch @switch = new Switch(switchClose, switchOpen);
            
            if (arg == "ON")
            {                
                @switch.Close();
            }
            else if (arg == "OFF")
            {                
                @switch.Open();
            }
            else
            {
                Console.WriteLine("Argumento \"ON\" ou \"OFF\" é necessário.");
            }
        }
    }
}
