using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        public void CreateBoard()
        {
            char[] board = new char[10];
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
    }
    }
