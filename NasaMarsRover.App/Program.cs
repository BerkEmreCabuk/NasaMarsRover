using System;
using NasaMarsRover.App.Enum;
using NasaMarsRover.App.Model;

namespace NasaMarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Input:");
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");
            Rover firstRover = new Rover(new Position(1, 2), new Plateau(5, 5), Directions.North);
            firstRover.Process("LMLMLMLMM");

            Console.WriteLine();
            Console.WriteLine("Test Input:");
            Console.WriteLine("5 5");
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");
            Rover secondRover = new Rover(new Position(3, 3), new Plateau(5, 5), Directions.East);
            secondRover.Process("MMRMMRMRRM");
        }
    }
}
