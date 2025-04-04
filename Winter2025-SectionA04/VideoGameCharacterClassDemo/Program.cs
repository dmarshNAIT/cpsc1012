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
        }
    }
}
