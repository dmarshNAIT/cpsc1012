namespace VideoGameClassDemo
{
    internal class VideoGameCharacter
    {

        /**** CHARACTERISTICS ****/
        // referenceID, characterID, special powers, mana/resource, aggression, morality, speed, combat style, attack modifier
        // TODO: add a static field
        private string _name = "Unknown";
        private float _level = 1;
        private double _hp = 100;


        /**** BEHAVIOUR ****/
        /*** CONSTRUCTORS ****/

        // parameterized constructor
        /// <summary>
        /// Construct a new VideoGameCharacter object
        /// </summary>
        /// <param name="name">The character's name</param>
        /// <param name="level">The level, defaults to 1</param>
        /// <param name="hp">The HP, defaults to 100</param>
        public VideoGameCharacter(string name, float level, double hp) {
            _name = name;
            _level = level;
            _hp = hp;
        }

        // no-argument constructor:
        /// <summary>
        /// Construct a new VideoGameCharacter object
        /// </summary>
        public VideoGameCharacter() { }

        /**** ACCESSOR METHODS ****/
        public string GetName() { return _name; }

        public float GetLevel() { return _level; }

        public double GetHP() {  return _hp; }



        // LevelUp, Heal, TakeDamage, IncreaseStat e.g. speed
        // stretch: DoDamage
        // perhaps adding something that interacts with another class?
    }
}
