using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameCharacterClassDemo
{
    internal class Weapon
    {
        /************************ FIELDS ************************/
        private string _name; // no blanks, max 20 characters
        private int _damage;  // 1 or greater

        /************************ PROPERTIES ************************/
        public string Name
        {
            get { return _name; }
            set {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                else if (value.Trim().Length > 20)
                    throw new ArgumentException("Name cannot be more than 20 characters long.");
                else 
                    _name = value.Trim(); // trim removes leading or trailing whitespaces
            }
        }

        public int Damage
        {
            get { return _damage; }
            set {
                if (value < 1)
                    throw new ArgumentException("Damage must be 1 or greater.");
                else 
                    _damage = value;
            }
        }

        /************************ CONSTRUCTOR ************************/

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
