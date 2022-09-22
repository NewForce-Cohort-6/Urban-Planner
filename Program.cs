using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneEighth = new Building("512 8th Avenue")
            {
                Stories = 2,
                Width = 18.3,
                Depth = 12.1
            };
            FiveOneEighth.BuildTheBuilding();
            FiveOneEighth.Purchase("Tommy");

            Building FifthAndFirst = new Building("500 1st Avenue")
            {
                Stories = 4,
                Width = 36.5,
                Depth = 12.1
            };
            FifthAndFirst.BuildTheBuilding();
            FifthAndFirst.Purchase("Jordan");

            // FiveOneEighth.DisplayInfo();
            // FifthAndFirst.DisplayInfo();

            City NewForceCity = new City("NewForce City");
            NewForceCity.AddBuilding(FiveOneEighth);
            NewForceCity.AddBuilding(FifthAndFirst);
            Console.WriteLine($"These are {NewForceCity.Name}'s Buildings:");
            Console.WriteLine("---------------");
            foreach (Building building in NewForceCity.ListOfBuildings) {   
                building.DisplayInfo();
            }
        }
    }
}

// Once the class is defined to your liking, refactor your code in Main() to create a new city instance and add your buildings to it. Once all buildings are in the city, refactor your code that outputs the building info to the console to be inside a foreach loop that iterate the city's building collection.
// Create several buildings in the Main() method of Program.cs.
// Building FiveOneTwoEigth = new Building("512 8th Avenue");
// Give each building a width, height, and number of stories.
// Construct each building.
// Have business people in your city purchase each of your buildings.