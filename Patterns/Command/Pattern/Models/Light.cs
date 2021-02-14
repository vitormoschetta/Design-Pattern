using System;
using Pattern.Interfaces;

namespace Pattern.Models
{
    public class Light : ISwitchable
    {
        public void PowerOn()
        {
            Console.WriteLine("A luz está ligada");
        }

        public void PowerOff()
        {
            Console.WriteLine("A luz está desligada");
        }
    }
}