using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class SupportingClass
    {
        // create checkforwinner method that determines if someone has won
        public int CheckForWinner(char[] choiceArray)
        {

            // create winner variable
            int winner;

            // check to see if there is a winner horizontally
            if ((choiceArray[0] == choiceArray[1]) & (choiceArray[1] == choiceArray[2]))
            {
                if (choiceArray[0] == 'X')
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }

            else if (choiceArray[3] == choiceArray[4] && choiceArray[4] == choiceArray[5])
            {
                if (choiceArray[3] == 'X')
                {
                    winner = 1;
                }

                else
                {
                    winner = 2;
                }

            }
            else if (choiceArray[6] == choiceArray[7] && choiceArray[7] == choiceArray[8])
            {
                if (choiceArray[6] == 'X')
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }

            }

            // check to see if there is a winner vertically
            else if (choiceArray[0] == choiceArray[3] && choiceArray[3] == choiceArray[6])
            {
                if (choiceArray[0] == 'X')
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }
            else if (choiceArray[1] == choiceArray[4] && choiceArray[4] == choiceArray[7])
            {
                if (choiceArray[1] == 'X')
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }
            else if (choiceArray[2] == choiceArray[5] && choiceArray[5] == choiceArray[8])
            {
                if (choiceArray[2] == 'X')
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }

            // Check to see if there is a winner diagonally
            else if (choiceArray[0] == choiceArray[4] && choiceArray[4] == choiceArray[8])
            {
                if (choiceArray[0] == 'X')
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }
            else if (choiceArray[2] == choiceArray[4] && choiceArray[4] == choiceArray[6])
            {
                if (choiceArray[2] == 'X')
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }

            // check if it is a tie game
            else
            {
                winner = 0;
            }
            return winner;
        }

        // Method that prints the tic tac toe game board
        public void PrintchoiceArray(char[] choiceArray)
        {
            Console.WriteLine("       |       |       ");
            Console.WriteLine($"   {choiceArray[0]}   |   {choiceArray[1]}   |   {choiceArray[2]}   ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine($"   {choiceArray[3]}   |   {choiceArray[4]}   |   {choiceArray[5]}   ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine($"   {choiceArray[6]}   |   {choiceArray[7]}   |   {choiceArray[8]}   ");
            Console.WriteLine("       |       |       ");
        }
    }
}
