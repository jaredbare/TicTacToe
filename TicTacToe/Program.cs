using System;

// Mission #3 Group Assignement - Tic Tac Toe Game
// Emily Reyes, Jared Bare, Jeremy Fairbanks, Natalie Kearl

namespace TicTacToe
{
    //Driver Class
    using System;

    public class Driver
    {

        static void Main(string[] args)
        {
            // declare and instantiate the supporting class
            SupportingClass sc2 = new SupportingClass();

            // print welcome message
            Console.WriteLine("Welcome to Tic-Tac-Toe");

            // create variables
            int turn = 1;
            int counter = 0;
            // create array that will hold the players choices
            char[] choiceArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // while there isn't a winner, keep the loop going
            while (sc2.CheckForWinner(choiceArray) == 0 && counter<9)
            {
                
                // if it is person 1's turn
                if (turn == 1)
                {
                    char ticTac = 'X';
                    Console.WriteLine("");
                    Console.WriteLine("Player 1: Which position would you like to choose?");
                    Console.WriteLine("");
                    // call the Game method 
                    Game(ticTac, choiceArray);
                    turn = turn + 1;
                    counter++;
                }
                // if it is person 2's turn
                else
                {
                    char ticTac = 'O';
                    Console.WriteLine("");
                    Console.WriteLine("Player 2: Which position would you like to choose?");
                    Console.WriteLine("");
                    // call the Game method
                    Game(ticTac, choiceArray);
                    turn = turn - 1;
                    counter++;
                }
                
            }

            SupportingClass sc = new SupportingClass();

            sc.PrintchoiceArray(choiceArray);

            // call checkforwinner method
            if (sc2.CheckForWinner(choiceArray) > 0)
            {
                Console.WriteLine("");
                // print the winner's name
                Console.WriteLine($"Player {sc2.CheckForWinner(choiceArray)} has won the game!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }  

        }

        // Game method
        public static void Game(char ticTac, char[] choiceArray)
        {
            int numChoice = 0;

            SupportingClass sc = new SupportingClass();

            sc.PrintchoiceArray(choiceArray);

            Console.WriteLine("");

            // use their input as the numChoice variable
            numChoice = Int32.Parse(Console.ReadLine());

            // check to see if a spot is already taken
            while (choiceArray[numChoice - 1] == 'X' || choiceArray[numChoice - 1] == 'O')
            {
                Console.Write("That spot is already taken!\n");
                Console.Write("Choose another position: ");
                numChoice = Int32.Parse(Console.ReadLine());
            }

            // replace the number they picked with X or O depending on whos turn it is
            choiceArray[numChoice - 1] = ticTac;
        }
    }
}


