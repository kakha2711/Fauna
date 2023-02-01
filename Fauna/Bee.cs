using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Bee : Insect
    {
        public Bee()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bee was created!");
            Console.ResetColor();
            Hony();
        }

        public bool Wild { get; set; }

        public void Hony()
        {
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("Honey is a domestic bee!");
            Console.ResetColor();
        }
    }
}