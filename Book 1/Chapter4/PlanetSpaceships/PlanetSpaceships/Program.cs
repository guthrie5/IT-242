using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planetList2 = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(planetList2);

            planetList.Insert(1, "Venus");

            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyplanets = planetList.GetRange(0, 4);
            rockyplanets.ForEach(planet => Console.WriteLine(planet));

            Random random = new Random();
            List<int> numbers = new List<int> {
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            };

            foreach (int x in numbers)
            {
                Console.WriteLine(x + " is the random number generated");
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"{i} is in the number range");
                }

                else 
              {
                    Console.WriteLine($"{i} isn't in the rumber range");
                }
            }
        }
    }
}
