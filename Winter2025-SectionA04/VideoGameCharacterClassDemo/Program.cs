namespace VideoGameCharacterClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate an object, using the default values
            // the name of the object is "kirby"
            VideoGameCharacter kirby = new VideoGameCharacter();
            // we can create a character using our parameterized constructor
            VideoGameCharacter zelda = new VideoGameCharacter("Zelda", 100, "Light", "Fist");

            // test our accessor methods:
            Console.WriteLine($"The HP of {zelda.GetName()} is {zelda.GetHP()}.");
            Console.WriteLine($"The Armor of {zelda.GetName()} is {zelda.GetArmor()}.");
            Console.WriteLine($"The Weapon of {zelda.GetName()} is {zelda.GetWeapon()}.");

            // test our mutator:
            Console.WriteLine($"The object's name is {kirby.GetName()}");
            kirby.SetName("Kirby");
            Console.WriteLine($"The object's name is {kirby.GetName()}");

        }
    }
}
