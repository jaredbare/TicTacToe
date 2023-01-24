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

            SupportingClass sc2 = new SupportingClass();

            Console.WriteLine("Welcome to Tic-Tac-Toe");

            int turn = 1;
            char[] choiceArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            while (sc2.CheckForWinner(choiceArray) == 0)
            {
                
                if (turn == 1)
                {
                    char ticTac = 'X';
                    Game(ticTac, choiceArray);
                    turn = turn + 1;
                }
                else
                {
                    char ticTac = 'O';
                    Game(ticTac, choiceArray);
                    turn = turn - 1;
                }
                
            }

         if (sc2.CheckForWinner(choiceArray) >= 0)
                Console.WriteLine($"Player {sc2.CheckForWinner(choiceArray)} has won the game!");
         else
                Console.WriteLine("It's a draw!");
         SupportingClass sc = new SupportingClass();
         sc.PrintchoiceArray(choiceArray);
        }

        public static void Game(char ticTac, char[] choiceArray)
        {
            int numChoice = 0;

            SupportingClass sc = new SupportingClass();

            sc.PrintchoiceArray(choiceArray);

            Console.Write("Which position would you like to choose? ");

            numChoice = Int32.Parse(Console.ReadLine());

            if (choiceArray[numChoice - 1] != ('X' | 'O'))
                choiceArray[numChoice - 1] = ticTac;
            else
                Console.Write("That spot is already taken asshole!");


        }
    }
}

