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

        int playeNum = 0;
        int turn = 0;
        string str;
        while (true)
        {
            // 나머지가 0이면 P1 1이면 P2  1->2->1 반복
            playeNum = turn % 2 == 0 ? 1 : 2;
            Console.Write($"P{playeNum} : ");
            str = Console.ReadLine();

            board = insertBoard(board, turn, str);
            printBoard(board);

            // 승리/무승부 조건 검사
            if (turn > 3) // 최소 5턴부터 승리자가 나올 수 있음
                GameOver(board);
            //ㅡㅡㅡㅡㅡ조건검사 끝
            turn++;
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

    static void GameOver(char[,] board)
    {
        char[] checkArr = new char[board.GetLength(1)];

        // 가로 검사
        bool pass = false;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] != 'X' && board[i, j] != 'O')
                {
                    pass = true;
                    Array.Clear(checkArr, 0, checkArr.Length);
                    break;
                }

                checkArr[j] = board[i, j];
            }
            if (!pass)
                Check(checkArr);
        }

        // 세로 검사
        pass = false;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[j, i] != 'X' && board[j, i] != 'O')
                {
                    pass = true;
                    Array.Clear(checkArr, 0, checkArr.Length);
                    break;
                }

                checkArr[j] = board[j, i];
            }
            if (!pass)
                Check(checkArr);
        }

        // 대각선 검사
        pass = false;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, i] != 'X' && board[i, i] != 'O')
            {
                pass = true;
                Array.Clear(checkArr, 0, checkArr.Length);
                break;
            }

            checkArr[i] = board[i, i];
        }

        if (!pass)
            Check(checkArr);

        // 대각선 검사 (반대방향)
        pass = false;
        for (int i = 0, j = board.GetLength(0) - 1; i < board.GetLength(0); i++)
        {
            if (board[i, j] != 'X' && board[i, j] != 'O')
            {
                pass = true;
                Array.Clear(checkArr, 0, checkArr.Length);
                break;
            }

            checkArr[i] = board[i, j--];
        }

        if (!pass)
            Check(checkArr);
    }

    static void Check(char[] checkArr)
    {
        int checkCnt = 0;
        for (int i = 0; i < checkArr.Length; i++)
        {
            if (checkArr[i] == 'X')
                checkCnt++;
        }

        if (checkCnt == checkArr.Length)
        {
            //P1 승리
            Console.WriteLine("P1 Win!!!!!");
        }
        else if (checkCnt == 0)
        {
            //P2 승리
            Console.WriteLine("P2 Win!!!!!");
        }
    }

    static void Main(string[] args)
    {
        ttt();
    }
}
