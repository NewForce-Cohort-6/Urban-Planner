using System;
using System.Collections.Generic;


namespace UrbanPlanner
{
   public class Building
    {
        private string _designer = "Sarah";
        private DateTime _dateConstructed {get; set;}
        private string _address {get; set;}
        private string _owner {get; set;}

        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }        
        }
        //constructor method (makes it required):
        public Building(string address) 
        {
            _address = address;
        }
        //method:
        public void BuildTheBuilding()
        {
            _dateConstructed = DateTime.Now;
        }
        //method:
        public void Purchase (string newName)
        {
            _owner = newName;
        }
        //method:
        public void DisplayInfo ()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine("--------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");

        }
    }
}

// 100 Main Street
// ---------------
// Designed by Steve Brownlee
// Constructed on 2/1/18 7:19:08 AM
// Owned by Bob Ross
// 16128 cubic meters of space

// Define a constructor method that accepts a single string argument - address - so that you can send as a parameter when you create each instance with new Building("800 8th Street");.

// The constructor's logic should set the _address field's value to the argument value
// Public Methods
// Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
// Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field.
// Neither of these methods will return a value.


// _designer of type string. It will hold your name.
// _dateConstructed of type DateTime. This will hold the exact time the building was created.
// _address of type string.
// _owner of type string. This will store the same of the person who owns the building.

// Stories typed as an integer.
// Width typed as a double.
// Depth typed as a double.
// Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.

