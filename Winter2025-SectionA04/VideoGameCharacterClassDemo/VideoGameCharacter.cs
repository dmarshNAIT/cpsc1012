namespace VideoGameCharacterClassDemo
{
    internal class VideoGameCharacter
    {

        /*** CHARACTERISTICS ***/
        private string _name = "Unknown";
        private int _hp = 100;
        private string _armor = "None";
        private string _weapon = "Fist";

        // stamina
        // gender
        // armor/weapon
        // hunger
        // luck
        // mana
        // evasiveness


        /*** BEHAVIOUR ***/
        /*** CONSTRUCTORS ***/
        // "greedy" constructor (takes ALL the parameters it can)
        public VideoGameCharacter(string name, int hp, string armor, string weapon)
        {
            // TODO: add validation
            _name = name;
            _hp = hp;
            _armor = armor;
            _weapon = weapon;
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
        public void SetName(string name) { 
            _name = name;
            // TODO: MISSING VALIDATION
        }


        // hp: this cannot be directly set to a new value
        // TODO: armor: this can change but it must be picked from a list of things they have
        // TODO: weapon: same idea as armor



        // attack?
        // dance?


    }
}
