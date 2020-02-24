using System;
using MarsRover.Concrete;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string commands1 = "LMLMLMLMM";
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.ApplyCommands(commands1);
            Console.WriteLine($"Input {commands1}");
            Console.WriteLine($"Output {firstRover.ToString()}");

            
            string commands2 = "MMRMMRMRRM";
            Plateau plateauTwo = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauTwo, new Position(3, 3), Directions.E);
            secondRover.ApplyCommands(commands2);
            Console.WriteLine($"Input {commands2}");
            Console.WriteLine($"Output {secondRover.ToString()}");

            Console.ReadLine();
        }
    }
}
