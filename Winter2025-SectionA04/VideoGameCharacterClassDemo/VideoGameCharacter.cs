using System.Xml.Linq;

namespace VideoGameCharacterClassDemo
{
    internal class VideoGameCharacter
    {

        /*** CHARACTERISTICS ***/
        private string _name = "Unknown";
        private int _hp = 100; // hp is between 0 and 100 (inclusive)
        private string _armor = "None";
        private string _weapon = "Fist";
        private List<string> _armorInventory = new List<string>();
        private List<Weapon> _weaponInventory = new List<Weapon>();

        // stamina
        // gender
        // armor/weapon
        // hunger
        // luck
        // mana
        // evasiveness

        /*** PROPERTIES ***/
        // instead of creating GetName() and SetName(), another approach is to create a single property called Name
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 10)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("The name must be 2-10 characters long.");
                }
            }
        }

        public string Armor
        {
            get { return _armor; }
            set
            {
                // we are only allowed to set Armor to a value that is ALREADY in the _armorInventory list
                if (_armorInventory.Contains(value))
                {
                    _armor = value;
                } else // not a valid option
                {
                    throw new Exception("NOOOO. You must select something from your inventory. :)");
                }
            }
        }


        /*** BEHAVIOUR ***/
        /*** CONSTRUCTORS ***/
        // "greedy" constructor (takes ALL the parameters it can)
        public VideoGameCharacter(string name, int hp, string armor, string weapon)
        {
            
            Name = name; // take advantage of the validation in the property
            SetHP(hp); // take advantage of the validation in SetHP()
            Armor = armor; // take advantage of the validation in the property
            _weapon = weapon; // TODO: add validation
        }

        // no-argument constructor (our version of the default constructor)
        public VideoGameCharacter() { }

        /*** ACCESSOR METHODS ***/
        public string GetName() { return _name; }
        public int GetHP() { return _hp; }
        public string GetArmor() { return _armor; }
        public string GetWeapon() { return _weapon; }

        /*** MUTATOR METHODS ***/
        // name: name must be 2-10 characters long
        public void SetName(string name)
        {
            if (name.Trim().Length >= 2 && name.Trim().Length <= 10)
            {
                _name = name;
            }
            else
            {
                throw new Exception("The name must be 2-10 characters long.");
            }
        }

        public void SetHP(int hp)
        {
            if (hp < 0 || hp > 100)
                throw new Exception("HP must be between 0 and 100.");
            else
                _hp = hp;
        }

        public void SetWeapon(string weaponName)
        {
            // look at the names of the weapons I have
            // we're only allowed to use those names

            bool isFound = false;

            // loop through our inventory and see if that weapon is in inventory already:
            foreach (Weapon weapon in _weaponInventory)
            {
                // if the parameter exactly matches the Name property of the weapon:
                if (weaponName == weapon.Name)
                    isFound = true;
            }

            if (isFound)
                _weapon = weaponName;
            else
                throw new Exception("Sorry, you don't have that weapon.");

        }


        // attack?
        // dance?
        // signature attack?

        /*** OTHER METHODS ***/
        public void AddArmorToInventory(string newArmorName)
        {            
            // add the item to the list
            _armorInventory.Add(newArmorName);
        }

        

    }
}
