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
            int counter = 0;
            char[] choiceArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            while (sc2.CheckForWinner(choiceArray) == 0 && counter<9)
            {
                
                if (turn == 1)
                {
                    char ticTac = 'X';
                    Console.WriteLine("");
                    Console.WriteLine("Player 1: Which position would you like to choose?");
                    Console.WriteLine("");
                    Game(ticTac, choiceArray);
                    turn = turn + 1;
                    counter++;
                }
                else
                {
                    char ticTac = 'O';
                    Console.WriteLine("");
                    Console.WriteLine("Player 2: Which position would you like to choose?");
                    Console.WriteLine("");
                    Game(ticTac, choiceArray);
                    turn = turn - 1;
                    counter++;
                }
                
            }
         SupportingClass sc = new SupportingClass();
         sc.PrintchoiceArray(choiceArray);
            if (sc2.CheckForWinner(choiceArray) > 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"Player {sc2.CheckForWinner(choiceArray)} has won the game!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }  

        }

        public static void Game(char ticTac, char[] choiceArray)
        {
            int numChoice = 0;

            SupportingClass sc = new SupportingClass();

            sc.PrintchoiceArray(choiceArray);

            Console.WriteLine("");

            numChoice = Int32.Parse(Console.ReadLine());

            while (choiceArray[numChoice - 1] == 'X' || choiceArray[numChoice - 1] == 'O')
            {
                Console.Write("That spot is already taken!\n");
                Console.Write("Choose another position: ");
                numChoice = Int32.Parse(Console.ReadLine());
            }

            choiceArray[numChoice - 1] = ticTac;
        }
    }
}


