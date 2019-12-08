using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //var rocketEquation = new RocketEquation();
            //Console.WriteLine(rocketEquation.GetTotalFuelRequirements());

            //var intCodeComputer = new IntCodeComputer();
            ////intCodeComputer.Parse();
            //var result = intCodeComputer.DetermineStartingInput(19690720);
            //if (result != null) {
            //  Console.WriteLine(result.Item1);
            //  Console.WriteLine(result.Item2);
            //}

            var DayThree = new Day3();
            Console.WriteLine(DayThree.ClosestManhattanDistanceFromCenter());
        }
    }
}
