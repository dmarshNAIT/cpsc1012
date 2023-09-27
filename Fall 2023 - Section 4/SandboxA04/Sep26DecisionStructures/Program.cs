namespace Sep26DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string userInput;
            int rating, 
                sum;

            // prompt
            Console.WriteLine("On a scale of 1-10, how excited are you?");

            // save their response
            userInput = Console.ReadLine();
            rating = int.Parse(userInput);

            // if they did not pick 10, complain
            if (rating < 10) {
                Console.WriteLine("Please go drink coffee.");
            } // this ends my if block
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good morning!");
                Console.ResetColor();
            } // this ends my else block


            // ask user what is 1+1=?
            Console.Write("What is 1 + 1 = ");
            userInput = Console.ReadLine();
            sum = Convert.ToInt32(userInput);

            // if they are correct: congrats!
            if(sum == 2)
            {
                Console.WriteLine("You got it! You're a math genius.");
            }
            else if (sum == 10 )
            {
                Console.WriteLine("Technically right if you're a computer.");
            }
            // otherwise, heckle and/or provide correct answer
            else
            {
                Console.WriteLine("The correct answer might be 2.");
            }


            // create 2 random numbers
            int randNum1 = 7;
            int randNum2 = 3;

            // calculate the sum of those random #s
            int correctAnswer = randNum1 + randNum2;

            // ask the user for their answer
            Console.Write($"What is {randNum1} + {randNum2} = ");
            userInput = Console.ReadLine();
            sum = Convert.ToInt32(userInput);

            // if they are correct, celebrate!
            if (sum == correctAnswer)
            {
                Console.WriteLine("That's correct!!");
            }
            // otherwise, show the correct answer
            else
            {
                Console.WriteLine("The correct answer is " + correctAnswer);
            }



        } // this ends my Main()
    } // this ends my class
} // this ends my namespace