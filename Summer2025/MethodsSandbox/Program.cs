namespace MethodsSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I want to call a method that will display a bunch of text.
            // no input needed, no output 
            PrintText();

            // I want to call a method which will return a value, but not require any input.
            int result = GetMeaningOfUniverse();

            // I want to call a method which takes input AND returns a value
            double half = DivideByTwo(3.14);

            // I want to call a method which takes input and returns nothing;
            PrintNumberAsCurrency(Math.PI);
        } // marks the end of the Main method

        // define a method with no inputs and no outputs:
        // i.e. a method with no parameters and a void return type
        static void PrintText()
        {
            Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc ac dolor a sapien dictum dictum vitae ut tortor. " +
                "Vivamus iaculis auctor magna vitae consectetur. " +
                "Quisque fermentum felis aliquet lorem sodales egestas. " +
                "Mauris rhoncus sapien sapien, sed imperdiet dolor semper nec. " +
                "Sed maximus laoreet sollicitudin. " +
                "Praesent ultricies mi nunc, sit amet rhoncus dui tristique et. " +
                "Nulla fringilla nec eros quis finibus. Suspendisse potenti. " +
                "Proin elementum, urna eget faucibus convallis, quam diam dapibus odio, " +
                "et scelerisque nibh elit id est. Donec volutpat in felis vel egestas. " +
                "Donec tincidunt eget tortor eu egestas. " +
                "Suspendisse eget nisl eget mauris maximus facilisis non vel enim. " +
                "In consectetur aliquet sodales. Sed pulvinar hendrerit purus, " +
                "pellentesque cursus ex tempor a. Maecenas libero erat, " +
                "sodales in turpis aliquet, blandit vehicula erat.\r\n\r\n");
        }

        // define a method with no parameters and which returns an int
        static int GetMeaningOfUniverse()
        {
            return 42;
        }

        // define a method with ONE parameter and a return value
        static double DivideByTwo(double number)
        {
            return number / 2;
        }

        // define a method with ONE parameter and a void return type
        static void PrintNumberAsCurrency(double number)
        {
            Console.WriteLine($"{number:c}");
        }

    } // marks the end of the class
}
