using System;

namespace TicTacToe
{
    //Driver Class
    using System;

    public class Driver
    {
        static char[] choiceArray;

        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            // Create a game choiceArray array to store the players' choices
            choiceArray = new char[9];

            // Check for a winner by calling the method in the supporting class
            // and notify the players when a win has occurred and which player won the game
            int winner = SupportingClass.CheckForWinner(choiceArray);
            if (winner > 0)
                Console.WriteLine($"Player {winner} has won the game!");
            else
                Console.WriteLine("It's a draw!");
        }
    }

    //Supporting Class

    public class SupportingClass
    {
        // Receive the “choiceArray” array from the driver class
        public static int CheckForWinner(char[] choiceArray)
        {
            // Horizontal wins

            int winner = 0;
            if (choiceArray[0] == choiceArray[1] && choiceArray[1] == choiceArray[2])
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
                if(choiceArray[0] == 'X')
                    winner = 1;
                else
                winner = 2;

            else
                return winner;
        }
        static void PrintchoiceArray(char[] choiceArray)
        {
            Console.WriteLine($" {choiceArray[0]} | {choiceArray[1]} | {choiceArray[2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {choiceArray[3]} | {choiceArray[4]} | {choiceArray[5]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {choiceArray[6]} | {choiceArray[7]} | {choiceArray[8]}");
        }
    }
}