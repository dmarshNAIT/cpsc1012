namespace LoopsSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bob = 4;
            Console.WriteLine($"Bob is currently {bob}."); // prints 4
            Console.WriteLine($"bob++ is equal to {bob++}."); // prints 4
            // we print the value of bob, THEN +1
            Console.WriteLine($"Bob is currently {bob}."); // prints 5
            Console.WriteLine($"bob++ is equal to {++bob}."); // prints 6
            // here we +1 THEN print the value
            int anotherVariable = bob++;

            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("this is the song that never ends....");
                counter++;
            }
            // a little silly because counters aren't USUALLY used for while loops, but a good simple example of how they work

            Console.WriteLine("--------------------------");

            for (int otherCounter = 0; otherCounter < 10; otherCounter++)
            {
                Console.WriteLine("this is the song that never ends....");
                //Console.WriteLine(otherCounter);
            }
        }
    }
}
