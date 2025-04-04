namespace VideoGameClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoGameCharacter letmesoloher = new VideoGameCharacter();
            // ^ this line will only work if we have a default constructor
            // (which means we didn't create ANY constructors so the compiler made one automatically), or
            // if we create a no-argument constructor

            VideoGameCharacter mario = new VideoGameCharacter("Mario", 1, 85);

            // let's test our accessor methods:
            Console.WriteLine($"The name of the character is {mario.GetName()}.");
            Console.WriteLine($"The level of the character is {mario.GetLevel()}.");
            Console.WriteLine($"The HP of the character is {mario.GetHP()}.");


        }
    }
}
