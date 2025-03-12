namespace StringFunctionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            int value = 42;

            // pad right adds spaces to the right-side of the string, to the specified total width:
            Console.WriteLine(name.PadRight(10) + " " + value);

            name = "Aioli";
            value = 1;

            Console.WriteLine(name.PadRight(10) + " " + value);

            // or we can put the spaces in front:
            Console.WriteLine("Bob".PadLeft(10) + value) ;
            Console.WriteLine("Aioli".PadLeft(10) + value) ;

            // what if we don't want spaces?
            Console.WriteLine("Bob".PadRight(10, '*') + value);
            Console.WriteLine("Aioli".PadRight(10, '*') + value);

        }
    }
}
