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
            try
            {
                kirby.SetName("X");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine($"The object's name is {kirby.GetName()}");

            // test our property:
            Console.WriteLine("The character's name is " + kirby.Name);
            kirby.Name = "Garlack th";
            Console.WriteLine("The character's name is " + kirby.Name);

            // test our armor functionality:
            // try to set the armor to an unallowed value
            try { kirby.Armor = "mud"; }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            // add armor to our inventory
            kirby.LootBattlefield();
            // try to set the armor to a allowed value
            kirby.Armor = "Ivaldi's Curse";
            // try to set the armor to an unallowed value
            try { kirby.Armor = "mud"; }
            catch (Exception ex) { Console.WriteLine(ex.Message); }



        }
    }
}
