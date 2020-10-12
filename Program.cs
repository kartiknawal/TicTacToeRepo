using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int location = 0;
            Console.WriteLine("Welcome to Tik Tak Toe program!");
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.CreateBoard();
            char playerLetter = ticTacToe.PlayerChoice();
            char computerLetter = ticTacToe.getComputerLetter(playerLetter);
            string player = ticTacToe.PlayerStartingFirst();
            while (true)
            {
                Console.WriteLine(player + " plays");
                if (player == "USER")
                {
                    location = ticTacToe.MoveToLocation();
                    ticTacToe.MakeAMove(location, playerLetter);
                }
                if (player == "COMPUTER")
                {
                    location = ticTacToe.GetComputerMove(computerLetter, playerLetter);
                    ticTacToe.MakeAMove(location, computerLetter);
                }
                ticTacToe.ShowBoard();
                if (ticTacToe.CheckWinner(playerLetter) == true)
                {
                    Console.WriteLine(player + " Has Won");
                    break;
                }
                if (ticTacToe.CheckDraw())
                {
                    Console.WriteLine("It's a tie");
                    break;
                }
                player = ticTacToe.PlayerChance(player);
            }


        }

    }
}
