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
    }
}
