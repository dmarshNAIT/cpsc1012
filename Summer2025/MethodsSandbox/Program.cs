namespace MethodsSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I want to call a method that will display a bunch of text.
            // no input needed, no output 
            PrintText();
            

        } // marks the end of the Main method

        // define a method with no inputs and no outputs:
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


    } // marks the end of the class
}
