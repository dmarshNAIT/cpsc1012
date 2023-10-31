namespace Oct31FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// create our StreamWriter object
            //StreamWriter writer = new StreamWriter("h.txt", true);
            // true means we want to append (add to the file)
            // false means we want to replace the contents of the file
            
            //// write to our file
            //writer.WriteLine("this file is named lowercaseH.");
            //writer.WriteLine("here is more text.");
            //writer.WriteLine("and some more.");

            //// close our file stream
            //writer.Close();

            // create our StreamReader object
            StreamReader reader = new StreamReader("h.txt");

            for(int i = 0; i < 5; i++)
            {
                // read in one line at a time:
                string line = reader.ReadLine();

                // print out that line to the Console
                Console.WriteLine(line);
            }

            // close our file connection
            reader.Close();
        }
    }
}