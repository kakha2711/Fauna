﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Alien : Creature
    {
        public Alien()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alien was created!");
            Console.ResetColor(); ;
        }
    }
}