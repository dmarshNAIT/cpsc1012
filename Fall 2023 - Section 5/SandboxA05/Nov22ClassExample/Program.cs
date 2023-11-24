namespace Nov22ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a new object
            Deity defaultDeity = new Deity();
            Deity flyingSpaghettiMonster = new Deity("FSM", true, true, 100);

            Console.WriteLine($"The god's name is {flyingSpaghettiMonster.GetName()}.");

            flyingSpaghettiMonster.SetName("Bob");

            Console.WriteLine($"The god's name is {flyingSpaghettiMonster.GetName()}.");

            flyingSpaghettiMonster.Inspire();


            Console.WriteLine("Goodbye!");
        }
    }
}