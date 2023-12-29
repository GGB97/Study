using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

public class TicTT
{
    static void ttt()
    {
        char[,] board = new char[3, 3];

        int n = 1; //초기화
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = char.Parse(n++.ToString());
            }
        }
        
        Console.WriteLine("입력 방식 : 1~9 를 선택");
        Console.WriteLine("P1 : X, P2: O");
        printBoard(board);

        int turn = 0;
        string str;
        while (true)
        {
            turn = turn % 2 == 0 ? 1 : 2;    // 나머지가 0이면 P1 1이면 P2
            Console.Write($"P{turn} : ");
            str = Console.ReadLine();

            board = insertBoard(board, turn, str);
            printBoard(board);

            // 승리/무승부 조건 검사
        }
    }

    static void printBoard(char[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static char[,] insertBoard(char[,] board, int turn, string str)
    {
        int n = 1;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (n == int.Parse(str))
                {
                    board[i, j] = turn % 2 == 0 ? 'X' : 'O';
                }

                n++;
            }
        }

        return board;
    }

    static void Main(string[] args)
    {
        ttt();
    }
}
