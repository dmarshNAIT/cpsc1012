namespace UserInputExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables that we need
            string userInput;
            int age;

            // ask a question:
            Console.Write("What food do you want to eat? ");
            // get the answer:
            userInput = Console.ReadLine();
            // print a message including that food name
            Console.WriteLine("Sounds like you are going to have " + userInput + " for lunch.");

            // let's ask another question, where the answer is a #
            Console.Write("How old are you in years? ");
            // read in their answer
            userInput = Console.ReadLine();
            // then turn it into a number
            age = int.Parse(userInput); // Parse will attempt to turn the string into an int
                                        // then I can print it out
            Console.WriteLine("You are " + age + " years old.");


            // let's create a double
            // then force it into an int and see what happens
            double bigNumber = 123456789012;
            int otherBigNumber = (int) bigNumber;
            Console.WriteLine("The value of otherBigNumber is " + otherBigNumber);

        }
    }
}
