using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    public class City
    {
        public string Name {get; set;}
        public string Mayor {get; set;}
        public string YearEstablished {get; set;}
        public List<Building> ListOfBuildings {get; set;} = new List<Building>();
        //method:
        public void AddBuilding(Building singleBuilding)
        {
            ListOfBuildings.Add(singleBuilding);
        }
       //constructor method:
        public City(string newName)
        {
            Name = newName;
        }
    }
}


// Name of the city.
// The mayor of the city.
// Year the city was established.
// A collection of all of the buildings in the city.
// A method to add a building to the city.