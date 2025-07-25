namespace ClassDemo_Dog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog fido = new Dog(); // instantiate an object using no-arg constructor
            Dog moose = new Dog("Moose", "large", 4);
            Dog puppy = new Dog("Spot", "small");

            // access the fields:
            // using an accessor method
            Console.WriteLine(fido.GetName());
            // or using a property:
            Console.WriteLine(fido.Name);

            // now let's give Fido a name using a setter:
            fido.SetName("Fido");
            // or using a property:
            fido.Name = "Fido";


        }
    }
}
