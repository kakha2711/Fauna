﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Human : Creature
    {
        public Human()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Human was created");
            Console.ResetColor();
        }
    }
}