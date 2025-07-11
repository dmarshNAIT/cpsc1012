namespace FileSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WRITE to a file (i.e. save to file)
            // we don't want to save to the default file location
            // instead, let's go up 3 levels,
            // so it's saved in the same folder as the program.cs file
            StreamWriter bob = new StreamWriter("../../../output.txt");
            bob.WriteLine("hello world");
            bob.Close();

            // READ from a file of KNOWN length (i.e. load from file)
            StreamReader marley = new StreamReader("../../../secret.txt");
            for (int i = 0; i < 3; i++)
            {
                string line = marley.ReadLine();
                Console.WriteLine(line);
            }
            marley.Close();

            // how to read from a file of UNKNOWN length
            StreamReader joe = new StreamReader("../../../secret.txt");
            while(joe.EndOfStream == false)
            {
                string line = joe.ReadLine();
                Console.WriteLine(line);
            }
            joe.Close();

            // remember: things can go wrong,
            // make sure your file read/write is inside a try block
        }
    }
}
