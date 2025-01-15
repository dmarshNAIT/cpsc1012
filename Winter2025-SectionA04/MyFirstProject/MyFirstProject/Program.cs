namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a comment.
            // it is for humans.
            // the following statements are demonstrating the difference between Write & WriteLine
            Console.Write("Chill guy shrugs shoulders.");
            Console.WriteLine("unshrugs\n\n\nshoulders");

            /* this is also a comment
             * this comment can span multiple lines
             * and end whenever I write */
            Console.WriteLine("\n\nMAIN MENU");
            Console.WriteLine("\tCalculate interest");
            Console.WriteLine("\tCalculate future earnings");
            Console.WriteLine("\tCheck current price");

            // let's create some variables
            int numberOfStudents = 22;
            // later, we can change its value:
            numberOfStudents = numberOfStudents + 1;
            // that is the same as:
            // numberOfStudents += 1;

            // we can also create a variable but NOT give it a value
            int numberOfPets;
            // later, we can assign its value:
            numberOfPets = 100;

            // let's create variables that CAN contain decimal values:
            double stockPrice = 1.23;
            double petsPerPerson = 2.0;
            double cupsOfCoffee = 3; // we can save an int into a double!

            // don't name variables like this:
            int MYNUMBER = 123;

            // this won't work:
            //int score = 1.5;
            Console.WriteLine("\n");

            // let's do math:
            int numberOfDonuts = 12;
            int leftovers = numberOfStudents % numberOfDonuts;
            // leftovers = the remainder when I divide 23/12
            Console.WriteLine("leftover donuts: " + leftovers);
            int donutsPerPerson = numberOfStudents / numberOfDonuts;
            Console.WriteLine("we each get " + donutsPerPerson + " donuts");

            // in C#, variables are named in camelCase
            // that means we start with a lowercase letter
            // if there are multiple words, every word is capitalized except the first word
            // e.g.   numberOfStudents, itemsOrdered, donutsPerPerson...

        }
    }
}
