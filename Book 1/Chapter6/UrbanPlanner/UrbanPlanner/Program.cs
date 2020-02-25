using System;
using System.Collections.Generic;


namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building MCTC = new Building("1 Mountwest Way", "Frank Lloyd Wright")
            {
                Width = 100,
                Depth = 200,
                NumberOfStories = 4,
            };
            
            Building CapitalBuilding = new Building("412 8th Street", "Renzo Piano")
            {
                Width = 1000,
                Depth = 500,
                NumberOfStories = 6,
            };

            Building MyHouse = new Building("1211 Kanawha Terrace", "Michael Guthrie")
            {
                Width = 13.5,
                Depth = 13.5,
                NumberOfStories = 1,

            };

            MCTC.Construct();
            CapitalBuilding.Construct();
            MyHouse.Construct();
            MCTC.Purchase("Russell");
            CapitalBuilding.Purchase("Alex");
            MyHouse.Purchase("Michael");

            MCTC.DisplayBuildingInfo();
            CapitalBuilding.DisplayBuildingInfo();
            MyHouse.DisplayBuildingInfo();
        }
    }
}
