namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here are examples of our 2 ways of printing text:
            Console.WriteLine("Peace be upon you.");
            Console.Write("What's up?");

            // here are examples of some "escape sequences"
            // \n means "new line"
            // \t means "tab" / indent
            Console.Write("Here is a list: \n");
            Console.Write("\tFirst Item\n\tSecond Item\n\tLast Item\n");

            // let's create some variables!
            // variables are named in camelCase
            // we start with a lowercase letter, any subsequent words are capitalized
            int age;
            int canadaPopulation = 41465298; // as of 2024

            age = 1;

            // let's pretend our creature has had a birthday
            age = age + 1;
            // here's the same thing written with a combined assignment operator:
            age += 1;

            // let's play around with data types:
            double popCost = 1.89;
            Console.WriteLine("The price of pop is " + popCost);

            // we are converting the data type
            // this means we LOSE data
            int newPopCost = (int)  1.99999999999999;
            Console.WriteLine("The price of pop is " + newPopCost);

            double coffeeCost = 1;
            coffeeCost = 1 + .50;
            //  because "coffeeCost" is a double, it can store double values AND int values

            const double GST_RATE = 0.05;
            // constants are not allowed to change
           //GST_RATE = 0.07;

        }
    }
}
