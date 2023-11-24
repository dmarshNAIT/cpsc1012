namespace Nov21ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a default Coffee object:
            Coffee basicCoffee = new Coffee();
            Coffee fancyCoffee = new Coffee("gingerbread oat chai", 'M', 85, false, 4, 2, "chai");

            //v1: using a property:
            Console.WriteLine($"You ordered a {fancyCoffee.Name}.");
            //v2: using a getter method
            Console.WriteLine($"You ordered a {fancyCoffee.GetName()}.");

            // changing the name
            //basicCoffee.SetName("x"); // this won't work bc of validation
            basicCoffee.SetName("slightly less basic");

            // changing the name using properties
            //basicCoffee.Name = "x";
            basicCoffee.Name = "fancier coffee";

            // adding sugar
            // let's add 2 sugars to our fancy coffee, then print out the amount of sugar in total
            Console.WriteLine($"The amount of sugar after adding 2 is {fancyCoffee.AddSugar(2)}.");

            Console.WriteLine("Haha.");

            List<string> toppings = new List<string>();
            toppings.Add("whipped cream");
            toppings.Capacity = 10;
        }
    }
}