using System;

namespace TicTacToe
{
    //Driver Class
    using System;

    public class Driver
    {
        //static char[] choiceArray;

        static void Main(string[] args)
        {

            // Create a game choiceArray array to store the players' choices
            //choiceArray = new char[9];

            int winner = 0;

            Console.WriteLine("Welcome to Tic-Tac-Toe");

            int turn = 1;
            char[] choiceArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            while (winner < 0)
            {

                if (turn == 1)
                {
                    char ticTac = 'X';
                    game(ticTac, choiceArray);
                    turn = turn + 1;
                }
                else
                {
                    char ticTac = 'O';
                    game(ticTac, choiceArray);
                    turn = turn - 1;
                }
            }
        }

        public static void game(char ticTac, char[] choiceArray)
        {
            int numChoice = 0;

            SupportingClass sc = new SupportingClass();

            sc.PrintchoiceArray(choiceArray);

            Console.Write("Which position would you like to choose? ");

            numChoice = Int32.Parse(Console.ReadLine());

            choiceArray[numChoice - 1] = ticTac;

            ticTac = 'O';

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