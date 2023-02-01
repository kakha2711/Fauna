using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    public class SuperDog : Dog
    {
        public SuperDog() : base()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SuperDog was created!");
            Console.ResetColor();
        }

        public void Fly()
        {
            Console.WriteLine("SuperDog is flying");
        }
    }
}
