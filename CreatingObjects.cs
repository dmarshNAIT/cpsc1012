/*
 * Purpose: Demonstrate creating a new class
 * Process: Create instances of a class to demonstrate functionality.
 * Input: N/A
 * Output: Messages to user about the character that was created.
 * 
 * Author: D Marsh & A02
 * Last modified: 2019-Nov-15
 * 
 */


using System;

namespace Sandbox {
    class Program {
        static void Main(string[] args) {
            CustomCharacter myCharacter = new CustomCharacter("Seven of Nine");

            Console.WriteLine($"We created a character called {myCharacter.GetName()}. They are Level {myCharacter.GetLevel()} and have an hp of {CustomCharacter.GetHP()}.");
            Console.WriteLine("The character has leveled up and is now level " + myCharacter.LevelUp() + ".");

            Console.ReadLine();
        } // eom
    } // eoc

    class CustomCharacter {
        // member fields:
        private string name;
        private int level = 1;
        private static int hp = 100;

        // constructors:
        public CustomCharacter(string characterName) {
            name = characterName;
        } // end method

        // other methods:
        public int LevelUp() {
            return ++level; 
        } // end method

        public void SetName(string characterName) {
            name = characterName;
        } // end method

        public string GetName() {
            return name;
        } // end method

        public int GetLevel() {
            return level;
        } // end method

        public static int GetHP() {
            return hp;
        } // end method

    } // end class
} // eon
