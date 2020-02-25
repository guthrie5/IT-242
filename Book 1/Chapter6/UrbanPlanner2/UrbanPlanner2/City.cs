using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner2
{
    class City
    {
        public City(string CityName)
        {
            NameOfCity = CityName;
        }

        public string NameOfCity { get; }
        public string Mayor { get; set; }
        public int YearEst { get; set; }
        public List<Building> CityBuildingList = new List<Building>
        {

        };
        public void AddBuilding (Building BuildingName)
        {
            CityBuildingList.Add(BuildingName);
        }
    }
}
