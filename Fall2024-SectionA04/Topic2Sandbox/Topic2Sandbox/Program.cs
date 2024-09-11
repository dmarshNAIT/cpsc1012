namespace Topic2Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yay, petting zoos.");
            Console.Write("Welcome!");
            Console.WriteLine("$900 to enter.");

            // let's create a variable:
            int numberOfAnimals = 99;
            Console.WriteLine("There are " + numberOfAnimals + " animals in the zoo.");

            double feedPrice = 9.95;
            Console.WriteLine("Feed costs $" + feedPrice);

            // doing math
            int numberOfStudents = 2;
            double piecesOfCandy = 5;
            // if BOTH operands are ints, the result will ALWAYS be an int. That's why we made one of the operands a double, instead.
            double candyPerStudent = piecesOfCandy / numberOfStudents;

            Console.WriteLine("Each student gets " + candyPerStudent + " pieces of candy.\n\n\n\n\n\n");

            double result = 2 / 7.0;
            Console.WriteLine("The answer is " + result);

            double roundedResult = Math.Round(result, 3);
            Console.WriteLine("The rounded answer is " + roundedResult);

            double myGrade = 84;
            int myGradeWholeNumber = (int) 84.2;
            Console.WriteLine(myGradeWholeNumber);

            // messing around with data types (DON'T DO THIS)
            double x = -3.14159;
            byte y = (byte) x;
            Console.WriteLine(y);

        }
    }
}
