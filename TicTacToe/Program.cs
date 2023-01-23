using System;

namespace TicTacToe
{
    //Driver Class
    using System;

    public class Driver
    {
        static char[] board;

        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            // Create a game board array to store the players' choices
            board = new char[9];

            // Ask each player in turn for their choice and update the game board array
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write($"Player {((i % 2) + 1)}: Enter your choice: ");
                board[i] = Console.ReadLine()[0];
                // Print the board by calling the method in the supporting class
                PrintBoard();
            }

            // Check for a winner by calling the method in the supporting class
            // and notify the players when a win has occurred and which player won the game
            int winner = SupportingClass.CheckForWinner(board);
            if (winner > 0)
                Console.WriteLine($"Player {winner} has won the game!");
            else
                Console.WriteLine("It's a draw!");
        }

        static void PrintBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}");
        }
    }

    //Supporting Class

    public class SupportingClass
    {
        // Receive the “board” array from the driver class
        public static int CheckForWinner(char[] board)
        {
            // Horizontal wins
            if (board[0] == board[1] && board[1] == board[2])
                return (board[0] == 'X') ? 1 : 2;
            if (board[3] == board[4] && board[4] == board[5])
                return (board[3] == 'X') ? 1 : 2;
            if (board[6] == board[7] && board[7] == board[8])
                return (board[6] == 'X') ? 1 : 2;

            // Vertical wins
            if (board[0] == board[3] && board[3] == board[6])
                return (board[0] == 'X') ? 1 : 2;
            if (board[1] == board[4] && board[4] == board[7])
                return (board[1] == 'X') ? 1 : 2;
            if (board[2] == board[5] && board[5] == board[8])
                return (board[2] == 'X') ? 1 : 2;

            // Diagonal wins
            if (board[0] == board[4] && board[4] == board[8])
                return (board[0] == 'X') ? 1 : 2;
            if (board[2] == board[4] && board[4] == board[6])
                return (board[2] == 'X') ? 1 : 2;

            // No win
            return 0;
        }
    }
}