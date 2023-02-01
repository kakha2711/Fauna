using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Creature
    {
        public Creature()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Creature was created!");
            Console.ResetColor();
            Breath();
        }

        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("Creature eat");
        }

        protected void Breath()
        {
            Console.WriteLine("Creature is breathing");
        }
    }
}