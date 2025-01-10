using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nov21ClassExample
{
    internal class Coffee
    {
        // characteristics:
        private string _name = "coffee";
        private char _size = 'M'; // 'S', 'M', or 'L'
        private int _temperature = 85; // temp in C
        private bool _isIced;
        private int _numSugar;
        private int _numCream;
        private string _flavour = "medium roast";
        //private string[] _toppings = new string[5];

        // constructor methods
        // no-arg
        public Coffee() { }

        // parameterized constructor
        public Coffee(string name, char size, int temperature, bool isIced, int numSugar, int numCream, string flavour)
        {
            // our Properties / mutators have built in validation: we should use those instead of the fields directly.
            Name = name;
            _size = size; // not a good practice (see note above)
            SetTemperature(temperature);
            _isIced = isIced; // not a good practice (see note above)
            _numSugar = numSugar; // not a good practice (see note above)
            _numCream = numCream; // not a good practice (see note above)
            _flavour = flavour; // not a good practice (see note above)
            //_toppings = toppings;
        }

        // HOMEWORK: create a 3rd constructor with a subset of fields

        // getter methods
        // v1: using properties
        public string Name { 
            get { return _name; }
            set
            {
                if (value.Length < 3)
                    throw new Exception("Name is too short");
                else
                    _name = value;
            }
        }
        // v2: using getter method
        public string GetName()
        {
            return _name;
        }
        // HOMEWORK: make at least 2 more

        // setter methods
        public void SetName(string name)
        {
            // make sure there are at least 3 letters in the name
            if (name.Length < 3)
                throw new Exception("Name is too short");
            else
                _name = name;
        }

        public void SetTemperature(int temperature)
        {
            if(temperature < -5 )
            {
                throw new Exception("Too cold");
            }
            else if (temperature > 5499) // 5499 is the surface of the sun
            {
                throw new Exception("Too hot");
            }
            else
            {
                _temperature = temperature;
            }
        }

        // behaviour: Drink(), AddCream()
        public int AddSugar(int sugar)
        {
            _numSugar += sugar;
            return _numSugar;
        }
    }
}
