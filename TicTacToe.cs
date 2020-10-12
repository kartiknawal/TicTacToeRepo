using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        char[] board;
        public TicTacToe()
        {
            board = new char[10];
        }
        public void CreateBoard()
        {
            for (int i = 1; i <= 9; i++)
            {
                board[i] = ' ';
            }
        }

        public char PlayerChoice()
        {
            char choice;
            Console.WriteLine("Enter X or O");
            choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'X' || choice == 'O')
            {
                return choice;
            }

            PlayerChoice();
            return ' ';
        }
        public void MoveToLocation(char letter)
        {
            Console.WriteLine("Enter Location index from 1 to 9");
            int location = Convert.ToInt32(Console.ReadLine());
            if (location < 1 || location > 9)
            {
                Console.WriteLine("Not valid index");
                MoveToLocation(letter);
            }
            else if (board[location] == ' ')
            {
                board[location] = letter;
            }
            else
            {
                Console.WriteLine("Location already filled");
                MoveToLocation(letter);
            }
        }
        public void ShowBoard()
        {
            int i, j;
            for (i = 1; i < 10; i++)
            {
                if (i == 4 || i == 7)
                {
                    Console.WriteLine("\n");
                }
                Console.Write(board[i] + "|");
            }
        }
    }
}
