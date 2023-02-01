﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Animal : Creature
    {
        //public Animal()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Animal was created!");
        //    Console.ResetColor();
        //}

        public Animal(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Animal with name {name} was created!");
            Console.ResetColor();
            Name = name;
        }

        public bool Mammals { get; set; }
        public bool GrassEater { get; set; }

        public void Run()
        {
            Console.WriteLine("Animal is running");
        }
    }
}