using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Plane : Vehicle
    {
        public Plane()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Plan Was created!");
            Console.ResetColor();
            PassengerPlane();
            MilitaryPlane();
        }

        public void PassengerPlane()
        {
            Console.WriteLine("Passenger plane created!");
            Console.WriteLine();
        }

        public void MilitaryPlane()
        {
            Console.WriteLine("Military plane created!");
        }
    }
}