using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov20ClassPractice
{
    internal class SuperHero
    {
        // characteristics:
        private string _name;
        private string _superPower;
        private string _tragicBackstory;
        private int _yearsAsAvenger;
        private int _numKnownIdentity; // # of people who know their identity
        private bool _isRetired;
        private bool _usesWeapon;
        private bool _canFly;
        private bool _antiHero;

        // behaviour:
        /* constructor methods */
        public SuperHero()
        {
            _name = "Unknown";
            _superPower = "Unknown";
            _tragicBackstory = "Unknown";
        }

        public SuperHero(string name, string superPower, string tragicBackstory, int yearsAsAvenger, int numKnownIdentity, bool isRetired, bool usesWeapon, bool canFly, bool antiHero)
        {
            _name = name;
            _superPower = superPower;
            _tragicBackstory = tragicBackstory;
            _yearsAsAvenger = yearsAsAvenger;
            _numKnownIdentity = numKnownIdentity;
            _isRetired = isRetired;
            _usesWeapon = usesWeapon;
            _canFly = canFly;
            _antiHero = antiHero;
        }

        /* getter methods */

        /* setter methods */

        /* other methods */
    }
}
