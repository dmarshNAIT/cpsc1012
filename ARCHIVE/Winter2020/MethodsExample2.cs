using System;

namespace A05_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            do
            {
                DisplayMenu();
                userChoice = GetUserInt();
                PlayGame(userChoice);
                Console.WriteLine();
            } while (userChoice != 0);

            Console.WriteLine("Thanks for playing.");
        } // end Main method

        static void DisplayMenu()
        {
            Console.WriteLine("Please enter your choice." +
                "\n1. Roll a die" +
                "\n2. Addition Quiz" +
                "\n3. Rock Paper Scissors" +
                "\n0. Exit");
        } // end method

        static int GetUserInt()
        {
            int userInput = 0;
            bool validInput = false;
            do
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    validInput = true;
                } // end try
                catch
                {
                    Console.WriteLine("Invalid entry.");
                } // end catch
            } while (validInput == false);
            return userInput;
        } // end method

        static void PlayGame(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    RollADie();
                    break;
                case 2:
                    PlayAdditionQuiz();
                    break;
                case 3:
                    PlayRockPaperScissors();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            } // end switch
        } // end method

        static void RollADie()
        {
            Random numGenerator = new Random();
            int userGuess, randNum = numGenerator.Next(1, 7);
            string outputMessage;

            Console.WriteLine("What # would you like to guess?");
            userGuess = GetUserInt();
            if (randNum == userGuess)
            {
                outputMessage = "You got it!";
            } // end if
            else
            {
                outputMessage = $"Nope - it was {randNum}.";
            } // end else

            Console.WriteLine(outputMessage);
        } // end method

        static void PlayAdditionQuiz()
        {
            // declare:
            int numQuestions, numCorrect = 0;
            Random numGenerator = new Random();
            const int MIN_NUMBER = 1, MAX_NUMBER = 10;

            // ask user how many questions they want
            Console.WriteLine("How many Qs do you want to answer?");
            numQuestions = GetUserInt();

            for (int counter = 0; counter < numQuestions; counter++)
            {
                int userGuess, 
                    randNum1 = numGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1), 
                    randNum2 = numGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);

                Console.WriteLine($"What is the sum of {randNum1} + {randNum2}?");
                userGuess = GetUserInt();

                if (userGuess == (randNum1 + randNum2))
                {
                    numCorrect++;
                } // end if
            } // end for loop

            Console.WriteLine($"You got {numCorrect}/{numQuestions} correct.");
        } // end method

        static void PlayRockPaperScissors()
        {
            // declare
            int computerMove, humanMove;
            Random numGenerator = new Random();
            string outputMessage;

            // generate computer's move
            computerMove = numGenerator.Next(1, 4);

            // ask player for their move
            Console.WriteLine("Would you like to play (1) Paper, (2) Scissors, or (3) Rock?");
            humanMove = GetUserInt();

            // compare and see who won
            if (computerMove == humanMove)
            {
                outputMessage = "Tie!";
            } // end if
            else if (humanMove - (computerMove % 3) == 1)
            {
                outputMessage = "You win!";
            } // end else-if
            else
            {
                outputMessage = "Computer wins!";
            } // end else

            Console.WriteLine(outputMessage);

        } // end method

    } // end class
} // end namespace
