/*
 * To demonstrate reading from and writing to a text file.
 */
namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // to write to a file, first we need to create a StreamWriter object
                StreamWriter writer = new StreamWriter("../../../data.txt");
                // instead of the default location, we are saving it 3 levels higher
                writer.Write("hello world, ");
                writer.WriteLine("more text");
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Something went wrong saving to the file.");
            }

            try
            {
                // create a reader object
                StreamReader reader = new StreamReader("../../../Customer.txt");

                // then read the file, line by line
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }

                // then close the stream
                reader.Close();
            }
            catch
            {
                Console.WriteLine("Something went wrong reading the file.");
            }

            // or, with "using":
            try
            {
                // create a reader object
                using (StreamReader reader = new StreamReader("../../../Customer.txt"))
                {
                    // then read the file, line by line
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong reading the file.");
            }

        }
    }
}
