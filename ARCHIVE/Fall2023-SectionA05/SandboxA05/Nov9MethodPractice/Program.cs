namespace Nov9MethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = 4;

            // get input from the user
            GetInput();
            // calculate something
            int result = CalculateSomething(magicNumber);
            // display results
            DisplayStuff();


            // create a variable
            int myInt = 15;


            // create a brand new array
            int[] dfsilsdflkjdfs = new int[5];

            int[] andy = { 5, 4, 3, 2, 6 };

            for(int i = 0; i < andy.Length; i++)
            {
                Console.WriteLine($"The value in my array is {andy[i]}");
            }
        }

        static void GetInput()
        {

        }

        static int CalculateSomething(int numDays)
        {
            int numHours = numDays * 24;

            return numHours;
        }

        static void DisplayStuff()
        {

        }
    }
}