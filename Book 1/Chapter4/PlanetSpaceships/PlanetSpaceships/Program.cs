using System;
using System.Collections.Generic;

namespace PlanetSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> newplanetList = new List<string>() { "Neptune", "Uranus" };

            newplanetList.AddRange(planetList);

            newplanetList.Add("Pluto");

            newplanetList.GetRange()
        }
    }
}
