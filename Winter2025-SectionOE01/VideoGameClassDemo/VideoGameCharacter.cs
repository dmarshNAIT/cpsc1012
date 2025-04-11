namespace VideoGameClassDemo
{
    internal class VideoGameCharacter
    {
        private const float DEFAULT_LEVEL = 1;
        private const float MAX_LEVEL = 100;
        private const double DEFAULT_HP = 100;
        private const double MAX_HP = 250;

        /**** CHARACTERISTICS ****/
        // referenceID, characterID, special powers, mana/resource, aggression, morality, speed, combat style, attack modifier
        private static int s_characterCount;

        private string _name = "Unknown"; // names must be 2-20 chars
        private float _level = DEFAULT_LEVEL;  // levels are between 1 & 100, inclusive
        private double _hp = DEFAULT_HP;  // HP has a min of 0 & a max of 250

        /*** PROPERTIES ***/
        // INSTEAD of a GetHP() and a SetHP(), another approach would be to create a property called HP (named in PascalCase)
        // which contains both get & set functionality
        public double HP
        {
            get { return _hp; }
            set
            {
                if (value < 0 || value > MAX_HP)
                { throw new ArgumentException($"HP must be between 0 and {MAX_HP}."); }
                else
                { _hp = value; }
            }
        }

        public static int CharacterCount
        {
            get { return s_characterCount; }
        }

        /*
         Level 1-25:    Iron
         Level 26-50:   Bronze
         Level 51-75:   Silver
         Level 76-100:  Gold
         */
        public string CharacterRank
        {
            get
            {
                string rank;
                if (_level <= 25)
                    rank = "Iron";
                else if (_level <= 50)
                    rank = "Bronze";
                else if (_level <= 75)
                    rank = "Silver";
                else
                    rank = "Gold";
                return rank;
            }
        }

        /**** BEHAVIOUR ****/
        /*** CONSTRUCTORS ****/

        // parameterized constructor
        /// <summary>
        /// Construct a new VideoGameCharacter object. As this uses all the fields in the class, this is a greedy constructor.
        /// </summary>
        /// <param name="name">The character's name</param>
        /// <param name="level">The level, defaults to 1</param>
        /// <param name="hp">The HP, defaults to 100</param>
        public VideoGameCharacter(string name, float level, double hp)
        {
            SetName(name); // using the validation in our setter
            // we do not have this in a try/catch, because we only want to catch an Exception if we can do something useful about it.
            // in this case, it's not the constructor's responsibility to fix.
            // it's the responsibility of whatever method called the constructor to provide valid parameters.
            SetLevel(level);  // using the validation in our setter
            HP = hp; // using the validation in our property
            s_characterCount++;
        }

        // no-argument constructor:
        /// <summary>
        /// Construct a new VideoGameCharacter object
        /// </summary>
        public VideoGameCharacter()
        {
            s_characterCount++;
        }

        /**** ACCESSOR METHODS ****/
        public string GetName() { return _name; }

        public float GetLevel() { return _level; }

        public double GetHP() { return _hp; }

        /**** MUTATOR METHODS ****/
        public void SetName(string name)
        {
            if (name.Length < 2 || name.Length > 20)
                throw new Exception("Names must be 2-20 characters long.");
            else
                _name = name;
        }

        public void SetLevel(float level)
        {
            if (level < 1 || level > MAX_LEVEL)
            {
                // INVALID
                throw new Exception($"Level must be between 1 and {MAX_LEVEL}.");
            }
            else
            {
                // VALID
                _level = level;
            }
        }

        public void SetHP(double hp)
        {
            if (hp < 0 || hp > MAX_HP)
            { throw new Exception($"HP must be between 0 and {MAX_HP}."); }
            else
            { _hp = hp; }
        }


        /*** INSTANCE METHODS ***/
        /// <summary>
        /// This method will add one to the object's level.
        /// </summary>
        /// <returns>the new value of the level</returns>
        public float LevelUp()
        {
            // +1 to the level field
            try
            {
                SetLevel(_level + 1);
            }
            catch (Exception e)
            {
                // do nothing?
                Console.WriteLine("Your character is already at the max level.");
            }

            // return the new level
            return _level;
        }

        public void Heal(double value)
        {
            // set hp = hp + value
            // if hp goes too high: catch the exception

            try
            {
                HP += value;
            }
            catch
            {
                HP = MAX_HP;
            }
        }

        public string ShowDetails()
        {
            return _name.PadRight(21) + $"{_level:000}" + CharacterRank.PadRight(7) + $"{_hp:000}"; 
        }

        // this next method could have been created in the Program class.
        // the only change is we would remove the modifier public
        public static bool SaveToFile(List<VideoGameCharacter> list)
        {
            bool isSaved;
            const string FILENAME = "characters.csv";

            try
            {
                // create the StreamWriter object
                StreamWriter writer = new StreamWriter($"../../../{FILENAME}");
                // add the header
                writer.WriteLine("Name,Level,HP");

                // go through our list, and print the data line by line
                for (int i = 0; i < list.Count; i++)
                {
                    string name = list[i].GetName();
                    float level = list[i].GetLevel();
                    double hp = list[i].GetHP();

                    writer.WriteLine(name + ',' + level + ',' + hp);
                }

                // close the connection
                writer.Close();
                isSaved = true;
            }
            catch
            {
                isSaved = false;
            }

            return isSaved;
        }

        public static bool LoadFromFile(List<VideoGameCharacter> list)
        {
            const string FILENAME = "characters.csv";
            bool isLoaded;

            try
            {
                // create our StreamReader object
                using (StreamReader reader = new StreamReader($"../../../{FILENAME}"))
                {
                    reader.ReadLine(); // read in the header, and do nothing with it

                    // read the file line by line
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        // for each line, we need to split apart the columns
                        string[] parts = line.Split(',');
                        string name = parts[0];
                        float level = float.Parse(parts[1]);
                        double hp = double.Parse(parts[2]);

                        // then we will use each field to create a new Character, and add them to the list
                        list.Add(new VideoGameCharacter(name, level, hp));
                    }
                }
                isLoaded = true;
            }
            catch
            {
                isLoaded = false;
            }
            return isLoaded;
        }


        // Heal, TakeDamage, IncreaseStat e.g. speed
        // stretch: DoDamage
        // perhaps adding something that interacts with another class?
    }
}
