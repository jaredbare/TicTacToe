using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class SupportingClass
    {
        // Receive the “choiceArray” array from the driver class
        public int CheckForWinner(char[] choiceArray)
        {
            // Horizontal wins

            int winner;
            if ((choiceArray[0] == choiceArray[1]) & (choiceArray[1] == choiceArray[2]))
                if (choiceArray[0] == 'X')
                    winner = 1;
                else
                    winner = 2;

            if (choiceArray[3] == choiceArray[4] && choiceArray[4] == choiceArray[5])
                if (choiceArray[3] == 'X')
                    winner = 1;
                else
                    winner = 2;
            if (choiceArray[6] == choiceArray[7] && choiceArray[7] == choiceArray[8])
                if (choiceArray[6] == 'X')
                    winner = 1;
                else
                    winner = 2;

            // Vertical wins
            if (choiceArray[0] == choiceArray[3] && choiceArray[3] == choiceArray[6])
                if (choiceArray[0] == 'X')
                    winner = 1;
                else
                    winner = 2;
            if (choiceArray[1] == choiceArray[4] && choiceArray[4] == choiceArray[7])
                if (choiceArray[0] == 'X')
                    winner = 1;
                else
                    winner = 2;
            if (choiceArray[2] == choiceArray[5] && choiceArray[5] == choiceArray[8])
                if (choiceArray[0] == 'X')
                    winner = 1;
                else
                    winner = 2;

            // Diagonal wins
            if (choiceArray[0] == choiceArray[4] && choiceArray[4] == choiceArray[8])
                if (choiceArray[0] == 'X')
                    winner = 1;
                else
                    winner = 2;
            if (choiceArray[2] == choiceArray[4] && choiceArray[4] == choiceArray[6])
                if (choiceArray[0] == 'X')
                    winner = 1;
                else
                    winner = 2;

            else
                winner = 0;
            return winner;
        }
        public void PrintchoiceArray(char[] choiceArray)
        {
            Console.WriteLine($" {choiceArray[0]} | {choiceArray[1]} | {choiceArray[2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {choiceArray[3]} | {choiceArray[4]} | {choiceArray[5]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {choiceArray[6]} | {choiceArray[7]} | {choiceArray[8]}");
        }
    }
}
