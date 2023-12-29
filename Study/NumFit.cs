using System;

public class NumFit
{
    public static void fit()
    {
        Random rand = new Random();
        int n = rand.Next(1, 101);

        string str; int cnt = 0; int input = 0;
        Console.WriteLine("숫자 맞추기 게임을 시작합니다. 1~100 사이의 숫자를 맞추세요.---"+ n);
        while (true)
        {
            Console.Write("숫자를 입력하세요 : ");
            str = Console.ReadLine();
            input = int.Parse(str);

            cnt++;
            if (n == input)
            {
                Console.WriteLine($"정답! 시도횟수 : {cnt}");
                break;
            }
            else if (n < input)
            {
                Console.WriteLine("down");
            }
            else if (n > input)
            {
                Console.WriteLine("up");
            }
        }
    }
}
