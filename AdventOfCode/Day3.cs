using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode
{
    public class Day3
    {
        public string WireOneInput { get; set; }
        public string WireTwoInput { get; set; }

        public Day3()
        {
            int counter = 0;
            var file = new  System.IO.StreamReader(@".\Data\DayThree.txt");
            string line;
            while((line = file.ReadLine()) != null)
            {
                if(counter == 0)
                {
                    WireOneInput = line;
                }
                else
                {
                    WireTwoInput = line;
                }
                counter++;
            }
        }

        public int ClosestManhattanDistanceFromCenter()
        {
            var pathOne = CalculatePathOfWire(WireOneInput);
            var pathTwo = CalculatePathOfWire(WireTwoInput);
            return pathOne.Intersect(pathTwo).Select(p => Math.Abs(p.x) + Math.Abs(p.y)).Min(); 
        }

        private List<(int x, int y)> CalculatePathOfWire(string input)
        {
            var path = new List<(int x, int y)>();
            var inputs = input.Split(',');
            foreach(var move in inputs)
            {
                var direction = move[0];
                var distance = int.Parse(move.Substring(1));
                var previousX = path.Count == 0 ? 0 : path[path.Count - 1].x;
                var previousY = path.Count == 0 ? 0 : path[path.Count - 1].y;
                var counter = 1;
                if (direction == 'U')
                {
                    while(counter <= distance)
                    {
                        path.Add((previousX, previousY + counter));
                        counter++;
                    }
                }
                else if (direction == 'D')
                {
                    while (counter <= distance)
                    {
                        path.Add((previousX, previousY - counter));
                        counter++;
                    }
                }
                else if (direction == 'R')
                {
                    while (counter <= distance)
                    {
                        path.Add((previousX + counter, previousY));
                        counter++;
                    }
                }
                else if (direction == 'L')
                {
                    while (counter <= distance)
                    {
                        path.Add((previousX - counter, previousY));
                        counter++;
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid Direction");
                }
                
            }
            return path;
        }
    }
}
