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
        private string Name;
        private int Level = 1;
        private static int Hp = 100;

        // constructors:
        public CustomCharacter(string characterName) {
            Name = characterName;
        } // end method

        // other methods:
        public int LevelUp() {
            return ++Level; 
        } // end method

        public void SetName(string characterName) {
            Name = characterName;
        } // end method

        public string GetName() {
            return Name;
        } // end method

        public int GetLevel() {
            return Level;
        } // end method

        public static int GetHP() {
            return Hp;
        } // end method

    } // end class
} // eon
