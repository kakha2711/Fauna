using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Car was created!");
            Console.ResetColor();
            Light();
            Truck();
            Heavy();
        }

        public void Light()
        {
            Console.WriteLine("Light car created!");
            Console.WriteLine();
        }

        public void Truck()
        {
            Console.WriteLine("Truck car created!");
            Console.WriteLine();
        }

        public void Heavy()
        {
            Console.WriteLine("Heavy car created!");
        }
    }
}