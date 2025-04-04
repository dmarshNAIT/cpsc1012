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
        public VideoGameCharacter (string name, int hp, string armor, string weapon)
        {
            // TODO: add validation
            _name = name;
            _hp = hp;   
            _armor = armor;
            _weapon = weapon;
        }

        // no-argument constructor (our version of the default constructor)
        public VideoGameCharacter() { }



        // attack?
        // dance?


    }
}
