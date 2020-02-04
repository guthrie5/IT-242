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


        }
    }
}
