using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Spider : Insect
    {
        public Spider()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spider Was created");
            Console.ResetColor();
        }

        public void Network()
        {

        }
    }
}