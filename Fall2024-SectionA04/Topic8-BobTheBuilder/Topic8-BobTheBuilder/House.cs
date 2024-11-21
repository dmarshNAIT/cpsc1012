using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic8_BobTheBuilder
{
    internal class House
    {
        // static fields would go first, if we had any

        // instance fields, AKA member variables:
        // determine data types, names, initial values
        // visibility should always be private
        private int _numberRooms; // ints default to 0
        private int _numberFloors = 1;
        private double _temperature = 19;
        private bool _hasGarage;  // bools default to false

        // no-argument constructor:
        public House() { }

        // greedy constructor: all the params!
        public House(int numberRooms, int numberFloors, double temperature, bool hasGarage)
        {
            _numberRooms = numberRooms;
            _numberFloors = numberFloors;
            _temperature = temperature;
            _hasGarage = hasGarage;
        }

        public int NumberRooms
        {
            get { return _numberRooms; }
            set
            {
                if (value > 0) { _numberRooms = value; }
                else { throw new Exception("Rooms must be > 0."); }
            }
        }
        public int NumberFloors
        {
            get { return _numberFloors; }
            set
            {
                if (value > 0) { _numberFloors = value; }
                else { throw new Exception("Floors must be > 0."); }
            }
        }

        // we have 2 ways of providing get/set functionality
        // option 1: getter & setter methods
        public double GetTemperature()
        {
            return _temperature;
        }
        public void SetTemperature(double temperature)
        {
            if (temperature <= 0)
                throw new Exception("Temperature must be above 0.");
            else if (temperature > 50)
                throw new Exception("Temperature must be below 50.");
            else
                _temperature = temperature;
        }

        // option 2: properties
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (value <= 0)
                    throw new Exception("Temperature must be above 0.");
                else if (value > 50)
                    throw new Exception("Temperature must be below 50.");
                else
                    _temperature = value;
            }
        }

        public bool HasGarage
        {
            get { return _hasGarage; }
            set { _hasGarage = value; }
        }

        // LATER:
        // add some other methods
        // Renovate(), Decorate / adding furniture

    }
}