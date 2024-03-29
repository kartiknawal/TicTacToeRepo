﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        public static int HEADS = 1;
        public static int TAILS = 0;
        char[] board;

        public TicTacToe()
        {
            board = new char[10];
        }
        public string PlayerStartingFirst()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            if (toss == HEADS)
            {
                return "USER";
            }
            return "COMPUTER";
        }
        public string PlayerChance(string player)
        {
            if (player == "USER")
            {
                return "COMPUTER";
            }
            return "USER";
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
        public char getComputerLetter(char playerLetter)
        {
            if (playerLetter == 'X')
                return 'O';
            return 'X';
        }
        public int MoveToLocation()
        {
            Console.WriteLine("Enter Location index from 1 to 9");
            int location = Convert.ToInt32(Console.ReadLine());
            if (location < 1 || location > 9)
            {
                Console.WriteLine("Not valid index");
                MoveToLocation();

            }
            if (isSpaceFree(location) == false)
            {
                Console.WriteLine("Location already filled");
                MoveToLocation();
            }
            return location;

        }
        public bool isSpaceFree(int location)
        {
            return (board[location] == ' ');

        }
        public void MakeAMove(int location, char letter)
        {
            board[location] = letter;
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
            Console.WriteLine("\n");
        }
        public bool CheckWinner(char playerLetter)
        {
            return ((board[1] == playerLetter && board[2] == playerLetter && board[3] == playerLetter) ||
                    (board[1] == playerLetter && board[4] == playerLetter && board[7] == playerLetter) ||
                    (board[1] == playerLetter && board[5] == playerLetter && board[9] == playerLetter) ||
                    (board[3] == playerLetter && board[6] == playerLetter && board[9] == playerLetter) ||
                    (board[3] == playerLetter && board[5] == playerLetter && board[7] == playerLetter) ||
                    (board[7] == playerLetter && board[8] == playerLetter && board[9] == playerLetter) ||
                    (board[4] == playerLetter && board[5] == playerLetter && board[6] == playerLetter) ||
                    (board[2] == playerLetter && board[5] == playerLetter && board[8] == playerLetter)
                   );
        }
        public bool CheckDraw()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (isSpaceFree(i) == true)
                    return false;
            }
            return true;
        }
        public int GetComputerMove(char computerLetter, char playerLetter)
        {
            int winningMove = GetWinningMove(computerLetter);
            if (winningMove != 0)
                return winningMove;
            int playerWinningMove = GetWinningMove(playerLetter);
            if (playerWinningMove != 0)
                return playerWinningMove;
            int[] cornerMoves = { 1, 3, 7, 9 };
            for (int i = 0; i < cornerMoves.Length; i++)
            {
                if (isSpaceFree(cornerMoves[i]))
                    return cornerMoves[i];
            }
            if (isSpaceFree(5))
                return 5;
            int[] sideMoves = { 2, 4, 6, 8 };
            for (int i = 0; i < sideMoves.Length; i++)
            {
                if (isSpaceFree(sideMoves[i]))
                    return sideMoves[i];
            }

            return 0;

        }
        public int GetWinningMove(char letter)
        {
            for (int i = 1; i < 10; i++)
            {
                if (isSpaceFree(i))
                {
                    MakeAMove(i, letter);
                    if (CheckWinner(letter))
                    {
                        board[i] = ' ';
                        return i;
                    }
                    board[i] = ' ';
                }
            }
            return 0;
        }
        public int getGameStatus(char letter)
        {
            if (CheckWinner(letter))
                return 0;
            if (CheckDraw())
                return 1;
            return 2;

        }
    }
}
