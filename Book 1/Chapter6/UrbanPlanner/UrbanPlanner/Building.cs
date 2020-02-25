using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        private string DesignerName { get; set; }

        private DateTime DateConstructed { get; set; }

        private string BuildingAddress { get; set; }

        private string BuildingOwner { get; set; }

        public int NumberOfStories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume {
            get
            {
                return Width * Depth * (3 * NumberOfStories);
            }

            
        }

        public Building(string address, string designer)
        {
            BuildingAddress = address;
            DesignerName = designer;
        }

        public void Construct()
        {
            DateConstructed = DateTime.Now;
        }

        public void Purchase (string buyer)
        {
            BuildingOwner = buyer;
        }

        public void DisplayBuildingInfo()
        {
            Console.WriteLine(BuildingAddress);
            Console.WriteLine("-------------------");
            Console.WriteLine("Designed by: " + DesignerName);
            Console.WriteLine("Constructed on " + DateConstructed);
            Console.WriteLine("Owned by " + BuildingOwner);
            Console.WriteLine(Volume + "cubic meters of space");
        }
    }
}