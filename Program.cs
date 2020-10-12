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
            char playerLetter = ticTacToe.PlayerChoice();
            ticTacToe.MoveToLocation(playerLetter);
            ticTacToe.ShowBoard();
        }
    }
}
