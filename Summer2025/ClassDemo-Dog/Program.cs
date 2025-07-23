namespace ClassDemo_Dog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog fido = new Dog(); // instantiate an object using no-arg constructor
            Dog moose = new Dog("Moose", "large", 4);
            Dog puppy = new Dog("Spot", "small");
        }
    }
}
