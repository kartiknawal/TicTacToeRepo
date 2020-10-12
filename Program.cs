using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tik Tak Toe program!");
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.CreateBoard();
            string player = ticTacToe.PlayerChance();
            char playerLetter = ticTacToe.PlayerChoice();
            int location = ticTacToe.MoveToLocation();
            ticTacToe.MakeAMove(location, playerLetter);
            ticTacToe.ShowBoard();
        }
    }
}
