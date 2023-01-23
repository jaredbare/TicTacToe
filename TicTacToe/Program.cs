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
}