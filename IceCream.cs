using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox
{
    class IceCream
    {
        // instance fields
        private string[] Toppings;
        private string[] Flavour = {"vanilla", null, null, null, null}; // COME BACK TO THIS WHEN WE HAVE LISTS.. this is not ideal
        private int NumberScoops = 2;
        private bool HasSprinkles;
        private string TypeOfCone = "regular";
        private string Base = "dairy";

        //constructor
        public IceCream() { } // default constructor

        public IceCream(string[] flavour, int scoops)
        {
            Flavour = flavour; // reference the array, a little weird but it works
            NumberScoops = scoops;
        } // end constructor

        // accessor:
        public int GetNumberOfScoops()
        {
            return NumberScoops;
        } // end GetNumberOfScoops()

        // mutator
        public void SetSprinkles(bool hasSprinkles)
        {
            HasSprinkles = hasSprinkles;
        } // end SetSprinkles()

        //other methods:
        public void Eat()
        {
            Console.WriteLine("Num Num Num lick slurp...");
        } // end method

    } // end of IceCream class
} // eon
