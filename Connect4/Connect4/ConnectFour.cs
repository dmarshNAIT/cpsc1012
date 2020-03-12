/* Class to play Connect 4.
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Connect4
{
    class ConnectFour
    {
        private char[,] gameBoard;
        private char humanSymbol;
        private char computerSymbol;
        private ConsoleColor humanColour;
        private ConsoleColor computerColour = ConsoleColor.Green;
        private bool humanTurn = true;
        private bool gameOver = false;
        private int numRows = 6; // standard board size
        private int numColumns = 7;  // standard board size
        private int spacesRemaining;

        public ConnectFour()
        {
            gameBoard = new char[numRows, numColumns];
            Console.Clear();

            // set symbols and colours for each player:
            humanSymbol = Program.GetUserChar("What symbol would you like to play with?");
            computerSymbol = (humanSymbol == '*') ? '@' : '*'; // make sure the computer uses a different symbol
            humanColour = Program.GetUserColour();
            spacesRemaining = numColumns * numRows;

            Console.WriteLine("\nPlease wait while we set up your board...");
            Thread.Sleep(2000); // dramatic pause

        } // end method

        public void DisplayBoard()
        {
            Console.Clear();
            string horizontalLine = "\n" + new string('-', this.gameBoard.GetLength(1) * 4 + 1);

            Console.Write("  ");
            for (int columnIndex = 0; columnIndex < this.gameBoard.GetLength(1); columnIndex++)
            {
                Console.Write(columnIndex);
                Console.Write("   ");
            } // end for

            Console.WriteLine(horizontalLine);

            for (int rowIndex = 0; rowIndex < this.gameBoard.GetLength(0); rowIndex++)
            {
                Console.Write("| ");
                for (int columnIndex = 0; columnIndex < this.gameBoard.GetLength(1); columnIndex++)
                {
                    string symbolToPrint = Char.ToString(this.gameBoard[rowIndex, columnIndex]);
                    if (this.gameBoard[rowIndex, columnIndex] == humanSymbol)
                    {
                        Program.WriteInColour(symbolToPrint, humanColour);
                    } // end if
                    else if (this.gameBoard[rowIndex, columnIndex] == computerSymbol)
                    {
                        Program.WriteInColour(symbolToPrint, computerColour);
                    } // end if
                    else
                    {
                        Console.Write(symbolToPrint);
                    } // end else         
                    Console.Write(" | ");
                } // end inner for
                Console.WriteLine(horizontalLine);
            } // end for
        } // end method

        public int GetIndexOfLowestAvailableSpot(char[,] board, int columnToCheck)
        {
            // check each row in the column
            for (int rowIndex = board.GetLength(0) - 1; rowIndex >= 0; rowIndex--)
            {
                if (board[rowIndex, columnToCheck] == '\0')
                    return rowIndex;
            } // end for

            return -1; // return -1 if there is no room left

        } // end method

        public void PlayGame()
        {
            do
            {
                DisplayBoard();

                PlayHumanTurn();

                if (!gameOver)
                {
                    Console.WriteLine("Now it's the computer's turn!");
                    Thread.Sleep(1000);

                    PlayComputerTurn();

                    if (spacesRemaining == 0) // also check after human's turn if it's not an even number of squares
                    {
                        gameOver = true;
                        Console.WriteLine("It's a tie game!");
                    } // end if

                } // end if

            } while (!gameOver);

        } // end method

        public void PlayHumanTurn()
        {
            // human turn:
            int whichColumn = Program.GetUserInt("Where would you like to play?");

            // check if it's a valid column
            while (whichColumn < 0 || whichColumn >= numColumns)
            {
                whichColumn = Program.GetUserInt("That's not a valid column. Please try another move.");
            } // end while

            // see if that column has room
            int rowToPlay = GetIndexOfLowestAvailableSpot(gameBoard, whichColumn);
            while (rowToPlay == -1)
            {
                whichColumn = Program.GetUserInt("That column is full. Please try another move.");

                // check if it's a valid column
                while (whichColumn < 0 || whichColumn >= numColumns)
                {
                    whichColumn = Program.GetUserInt("That's not a valid column. Please try another move."); // repetitive -- come back to this later
                } // end while

                rowToPlay = GetIndexOfLowestAvailableSpot(gameBoard, whichColumn);
            } // end while

            // if so, place, showing animation:
            PlayMove(whichColumn, rowToPlay);

            // check if win
            if (CheckIfWinner())
            {
                gameOver = true;
                Console.WriteLine("You win!");
            } // end if
        } // end method

        public void PlayComputerTurn()
        {
            // randomly generate a column
            Random numGenerator = new Random();
            int whichColumn = numGenerator.Next(numColumns);

            // make sure it's available
            int rowToPlay = GetIndexOfLowestAvailableSpot(gameBoard, whichColumn);
            while (rowToPlay == -1)
            {
                whichColumn = numGenerator.Next(numColumns);
                rowToPlay = GetIndexOfLowestAvailableSpot(gameBoard, whichColumn);
            } // end while

            PlayMove(whichColumn, rowToPlay);

            // check if win
            if (CheckIfWinner())
            {
                gameOver = true;
                Console.WriteLine("Computer wins!");
            } // end if

        } // end method

        public void PlayMove(int whichColumn, int rowToPlay)
        {
            DisplayBoard();

            // for each empty spot in the column:
            for (int rowIndex = 0; rowIndex < rowToPlay; rowIndex++)
            {
                gameBoard[rowIndex, whichColumn] = (humanTurn) ? humanSymbol : computerSymbol; // add the symbol to the top empty spot
                DisplayBoard();
                Thread.Sleep(500); // dramatic pause
                gameBoard[rowIndex, whichColumn] = '\0'; ; // remove the symbol
            } // end for

            gameBoard[rowToPlay, whichColumn] = (humanTurn) ? humanSymbol : computerSymbol; // play final turn
            spacesRemaining--;
            humanTurn = !humanTurn; // switch to other player's turn
            DisplayBoard();

        } // end method

        public bool CheckIfWinner()
        {
            // ways to win:
            // 4 in a row
            for (int rowIndex = 0; rowIndex <= numRows - 1; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex <= numColumns - 4; columnIndex++)
                {
                    if (gameBoard[rowIndex, columnIndex] != '\0' &&
                        gameBoard[rowIndex, columnIndex] == gameBoard[rowIndex, columnIndex + 1] &&
                        gameBoard[rowIndex, columnIndex + 1] == gameBoard[rowIndex, columnIndex + 2] &&
                        gameBoard[rowIndex, columnIndex + 2] == gameBoard[rowIndex, columnIndex + 3])
                        return true;
                } // end inner for

            } // end for

            // 4 in a column
            for (int rowIndex = 0; rowIndex <= numRows - 4; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex <= numColumns - 1; columnIndex++)
                {
                    if (gameBoard[rowIndex, columnIndex] != '\0' &&
                        gameBoard[rowIndex, columnIndex] == gameBoard[rowIndex + 1, columnIndex] &&
                        gameBoard[rowIndex + 1, columnIndex] == gameBoard[rowIndex + 2, columnIndex] &&
                        gameBoard[rowIndex + 2, columnIndex] == gameBoard[rowIndex + 3, columnIndex])
                        return true;
                } // end inner for

            } // end for

            return false;
        } // end method

    } // end class
} // end namespace
