/*
 * Purpose:     Given user-inputted values, calculate the "heat rating" of a hot sauce.
 * Author:      Dana Marsh with review by section OE01
 * Modified:    June 10, 2025
 * 
 * Input:       Customer's spice tolerance (1-10), base sauce spiciness (mild, medium, hot), 
 *              whether or not they'd like a spicy booster
 * Output:      Heat level, & a warning if the spice level is too high
 * 
*/
namespace DecisionStructureHotSauceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;

            do
            {
                // declare variables
                int spiceTolerance = 0;  //customer's spice tolerance
                string spiceDegree;  //choice of sauce spiciness
                string rawUserInput;
                char userInput;
                bool isExtraSpicy;   //whether or not they'd like a spicy booster
                int heatLevel = 0;       //heat level
                string outputMessage;
                bool isGoodInput = false;

                // get input from the user

                // spice tolerance
                do
                {
                    Console.Write("Please enter your spice tolerance from 1-10: ");
                    try
                    {
                        spiceTolerance = int.Parse(Console.ReadLine());
                        if(spiceTolerance < 1 || spiceTolerance > 10)
                        {
                            Console.WriteLine("Please enter a valid number. Try again.");
                        }
                        else
                        {
                            isGoodInput = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                } while (!isGoodInput);
                                                           

                // which level of spice
                do
                {
                    Console.Write("Please select your spice level: mild, medium, or hot: ");
                    spiceDegree = Console.ReadLine().ToLower().Trim();
                    // this forces the user's input to be lowercase, then trims any extra whitespace

                    // calculation
                    // mild = 2, medium = 5, hot = 8
                    switch (spiceDegree)
                    {
                        // if spiceDegree is mild:
                        case "mild":
                            heatLevel = 2;
                            isGoodInput = true;
                            break;
                        // if spiceDegree is medium:
                        case "medium":
                            heatLevel = 5;
                            isGoodInput = true;
                            break;
                        // if spiceDegree is hot:
                        case "hot":
                            heatLevel = 8;
                            isGoodInput = true;
                            break;
                        default:
                                 // this only runs if they enter an invalid choice
                            Console.WriteLine("That was not a valid choice.");
                            isGoodInput = false;
                            break;
                    } 
                } while (!isGoodInput);

                outputMessage = $"Your spice tolerance:{spiceTolerance, 5}\n" +
                    $"Base heat level:     {heatLevel,5}\n";

                // do they want a booster?
                Console.Write("Would you like your sauce to be extra spicy (yes/no): ");
                // save the first character of their answer:
                rawUserInput = Console.ReadLine().Trim().ToUpper();

                // make sure they entered at least one character:
                while (rawUserInput.Length < 1)
                {
                    Console.Write("Invalid answer. Please try again: ");
                    rawUserInput = Console.ReadLine().Trim().ToUpper();
                }

                userInput = rawUserInput[0]; 

                // assign a value to isExtraSpicy
                if (userInput == ('Y'))
                {
                    isExtraSpicy = true;
                }
                else
                {
                    isExtraSpicy = false;
                }
                // OR
                // isExtraSpicy = (userInput == ('Y'));

                // if they request extra spicy, +3 
                if (isExtraSpicy)
                {
                    heatLevel = heatLevel + 3;
                    outputMessage += $"Extra spice:             3\n";
                }

                // OR:
                // heatLevel = isExtraSpicy ? heatLevel + 2 : heatLevel;

                // output
                // print the overall heat level
                outputMessage += $"Overall heat level:  {heatLevel,5}";

                Console.WriteLine(outputMessage);

                // if they exceed their tolerance, print a warning
                if (heatLevel > spiceTolerance)
                {
                    Console.WriteLine("That's too spicy for you.");
                }

                Console.Write("Press Q to quit or any other key to continue.");
                userAnswer = Console.ReadLine().ToLower().Trim();

            } while ( userAnswer != "q");

            Console.WriteLine("Thanks, goodbye!");
        }
    }
}
