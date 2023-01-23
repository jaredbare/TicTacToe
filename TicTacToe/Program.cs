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

            // Ask each player in turn for their choice and update the game choiceArray array
            for (int i = 0; i < choiceArray.Length; i++)
            {
                Console.Write($"Player {((i % 2) + 1)}: Enter your choice: ");
                choiceArray[i] = Console.ReadLine()[0];
                // Print the choiceArray by calling the method in the supporting class
                PrintchoiceArray();
            }

            // Check for a winner by calling the method in the supporting class
            // and notify the players when a win has occurred and which player won the game
            int winner = SupportingClass.CheckForWinner(choiceArray);
            if (winner > 0)
                Console.WriteLine($"Player {winner} has won the game!");
            else
                Console.WriteLine("It's a draw!");
        }

        static void PrintchoiceArray()
        {
            Console.WriteLine($" {choiceArray[0]} | {choiceArray[1]} | {choiceArray[2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {choiceArray[3]} | {choiceArray[4]} | {choiceArray[5]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {choiceArray[6]} | {choiceArray[7]} | {choiceArray[8]}");
        }
    }

    //Supporting Class

    public class SupportingClass
    {
        // Receive the “choiceArray” array from the driver class
        public static bool CheckForWinner(char[] choiceArray)
        {
            // Horizontal wins
            bool winner = false;
            if (choiceArray[0] == choiceArray[1] && choiceArray[1] == choiceArray[2])
                winner = true;
            if (choiceArray[3] == choiceArray[4] && choiceArray[4] == choiceArray[5])
                winner = true;
            if (choiceArray[6] == choiceArray[7] && choiceArray[7] == choiceArray[8])
                winner = true;

            // Vertical wins
            if (choiceArray[0] == choiceArray[3] && choiceArray[3] == choiceArray[6])
                winner = true;
            if (choiceArray[1] == choiceArray[4] && choiceArray[4] == choiceArray[7])
                winner = true;
            if (choiceArray[2] == choiceArray[5] && choiceArray[5] == choiceArray[8])
                winner = true;

            // Diagonal wins
            if (choiceArray[0] == choiceArray[4] && choiceArray[4] == choiceArray[8])
                winner = true;
            if (choiceArray[2] == choiceArray[4] && choiceArray[4] == choiceArray[6])
                winner = true;

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