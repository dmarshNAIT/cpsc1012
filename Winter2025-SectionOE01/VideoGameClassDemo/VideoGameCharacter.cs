namespace VideoGameClassDemo
{
    internal class VideoGameCharacter
    {
        // TODO: create some constants to replace those "magic numbers"

        /**** CHARACTERISTICS ****/
        // referenceID, characterID, special powers, mana/resource, aggression, morality, speed, combat style, attack modifier
        // TODO: add a static field
        private string _name = "Unknown";
        private float _level = 1;  // levels are between 1 & 100, inclusive
        private double _hp = 100;  // HP has a min of 0 & a max of 250


        /**** BEHAVIOUR ****/
        /*** CONSTRUCTORS ****/

        // parameterized constructor
        /// <summary>
        /// Construct a new VideoGameCharacter object
        /// </summary>
        /// <param name="name">The character's name</param>
        /// <param name="level">The level, defaults to 1</param>
        /// <param name="hp">The HP, defaults to 100</param>
        public VideoGameCharacter(string name, float level, double hp)
        {
            _name = name;
            _level = level;
            _hp = hp;
            // TODO: missing validation
        }

        // no-argument constructor:
        /// <summary>
        /// Construct a new VideoGameCharacter object
        /// </summary>
        public VideoGameCharacter() { }

        /**** ACCESSOR METHODS ****/
        public string GetName() { return _name; }

        public float GetLevel() { return _level; }

        public double GetHP() { return _hp; }

        /**** MUTATOR METHODS ****/
        // we decided Names should not change

        public void SetLevel(float level)
        {
            if (level < 1 || level > 100)
            {
                // INVALID
                throw new Exception("Level must be between 1 and 100.");
            }
            else
            {
                // VALID
                _level = level;
            }
        }

        public void SetHP(double hp)
        {
            if (hp < 0 || hp > 250)
            { throw new Exception("HP must be between 0 and 250."); }
            else
            { _hp = hp; }
        }

        // INSTEAD of a GetHP() and a SetHP(), another approach would be to create a property called HP (named in PascalCase)
        // which contains both get & set functionality
        public double HP
        {
            get { return _hp; }
            set
            {
                if (value < 0 || value > 250)
                { throw new Exception("HP must be between 0 and 250."); }
                else
                { _hp = value; }
            }
        }


        // LevelUp, Heal, TakeDamage, IncreaseStat e.g. speed
        // stretch: DoDamage
        // perhaps adding something that interacts with another class?
    }
}
