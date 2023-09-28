namespace Sep27DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            byte userAge = 25;
            int mark,
                num1,
                num2,
                userAnswer,
                correctAnswer;
            decimal phoneNumber = 78012345670.0m;
            string inputString;
            char letterGrade;
            Random numberGenerator = new Random(); // this creates a Random object

            // prompt the user to enter their mark (as a whole #)
            Console.Write("Please enter your mark (as a whole #): ");
            inputString = Console.ReadLine();
            mark = int.Parse(inputString); // is a little faster
            mark = Convert.ToInt32(inputString); // is better at dealing with blank strings

            // if their mark is above 80, congrats!
            if (mark > 80)
            {
                Console.WriteLine("Congratulations!");
            }
            // if their mark is below 50:
            else if (mark < 50)
            {
                Console.WriteLine("Maybe you would like to schedule an office hour."); ;
            }
            // otherwise, tell them to keep up the good work.
            else
            {
                Console.WriteLine("Keep up the good work!");
            }

            // assign 5 bonus marks
            //mark = mark + 5;
            mark += 5;
            Console.WriteLine($"Your new grade is {mark}%.");

            // let's assign letter grades
            // if mark is at least 80: A
            if (mark >= 80)
            { letterGrade = 'A'; }
            // if mark is at least 70: B
            else if (mark >= 70)
            { letterGrade = 'B'; }
            // if mark is at least 60: C
            else if (mark >= 60)
            { letterGrade = 'C'; }
            // if mark is at least 50: D
            else if (mark >= 50)
            {letterGrade = 'D'; }
            // otherwise, F
            else { letterGrade = 'F'; }

            Console.WriteLine($"Your letter grade is {letterGrade}.");


            /*********** math quiz ***********/

            // generate 2 random #s
            num1 = numberGenerator.Next(1, 10); 
            // generates a random number that's at least 1 and less than 10
            // in other words, a digit between 1 and 9 (inclusive)
            num2 = numberGenerator.Next(1, 10);

            // ask the user to calculate the sum
            Console.Write($"\n\nWelcome to our Math Quiz!\nWhat is {num1} + {num2} = ");
            inputString = Console.ReadLine();
            userAnswer = int.Parse(inputString);

            correctAnswer = num1 + num2;

            // if they answer correctly: congratulate them
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Congrats! That is correct.");
            }
            // otherwise, we will tell them the correct answer
            else
            {
                Console.WriteLine($"Sorry, the correct answer is {correctAnswer}.");
            }





            Console.WriteLine("Goodbye.");

        }
    }
}