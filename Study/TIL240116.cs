using System;
using System.Text;

public class TIL240116
{
    // 코테 풀다가 string,char[],StringBuilder 간의 성능 차이를 확인?
    public static string solution(int n)
    {       // 내가 작성한 답
        char[] answer = new char[n];    // 미리 고정된 크기의 메모리를 할당하고 각 인덱스에 직접 접근하여 값을 변경
        for (int i = 0; i < n; i++)
        {
            answer[i] = i % 2 == 0 ? '수' : '박';
        }
        return new string(answer);
    }

    /*
                     char[]
            테스트 1 〉	통과 (0.29ms, 30.9MB)
            테스트 2 〉	통과 (0.35ms, 31.4MB)
            테스트 3 〉	통과 (0.31ms, 31MB)
            테스트 4 〉	통과 (0.35ms, 31.3MB)
            테스트 5 〉	통과 (0.33ms, 30.9MB)
            테스트 6 〉	통과 (0.28ms, 31MB)
            테스트 7 〉	통과 (0.30ms, 30.9MB)
            테스트 8 〉	통과 (0.29ms, 30.9MB)
            테스트 9 〉	통과 (0.35ms, 31.3MB)
            테스트 10 〉	통과 (0.31ms, 31MB)
            테스트 11 〉	통과 (0.32ms, 31MB)
            테스트 12 〉	통과 (0.29ms, 30.9MB)
            테스트 13 〉	통과 (0.29ms, 31.1MB)
            테스트 14 〉	통과 (0.33ms, 31.1MB)
            테스트 15 〉	통과 (0.61ms, 31MB)
            테스트 16 〉	통과 (0.29ms, 31.2MB)
     */


    public static string solution2(int n)
    {
        string answer = "";
        for (int i = 0; i < n; i++)
        {
            answer += i % 2 == 0 ? '수' : '박';   // 기존 문자열을 복사하고 변경된 부분을 추가하여 새로운 문자열을 생성
                                // 문자열을 더할 때마다 메모리의 새로운 영역이 할당되고 복사되므로 성능에 영향을 미칠 수 있음
        }
        return answer;
    }

    /*
                     string
            테스트 1 〉	통과 (1.19ms, 32MB)
            테스트 2 〉	통과 (3.89ms, 35.1MB)
            테스트 3 〉	통과 (3.83ms, 34.8MB)
            테스트 4 〉	통과 (11.37ms, 46.2MB)
            테스트 5 〉	통과 (3.21ms, 34.6MB)
            테스트 6 〉	통과 (0.28ms, 30.9MB)
            테스트 7 〉	통과 (0.22ms, 31MB)
            테스트 8 〉	통과 (0.25ms, 31MB)
            테스트 9 〉	통과 (0.25ms, 31MB)
            테스트 10 〉	통과 (0.22ms, 31.1MB)
            테스트 11 〉	통과 (0.24ms, 31MB)
            테스트 12 〉	통과 (0.33ms, 31MB)
            테스트 13 〉	통과 (0.36ms, 31.2MB)
            테스트 14 〉	통과 (0.23ms, 31.1MB)
            테스트 15 〉	통과 (63.57ms, 47.5MB)
            테스트 16 〉	통과 (0.24ms, 31.2MB)
     */


    public static string solution3(int n)   // isBest
    {
        StringBuilder answer = new StringBuilder(); // string의 저런 문제점 때문에 만들어진 클래스 같음
        for (int i = 0; i < n; i++)             // 문자열을 다룰때는 string에 +- 로 추가하는 방식 말고
        {                                       // StringBuilder를 사용하는게 훨씬 효율적 인 것 같음 (횟수가 많아질수록 테스트 15번 차이가 많이남)
            answer.Append(i % 2 == 0 ? '수' : '박');
        }
        return answer.ToString();
    }

    /*
                    StringBuilder
            테스트 1 〉	통과 (0.23ms, 31.2MB)
            테스트 2 〉	통과 (0.25ms, 31.1MB)
            테스트 3 〉	통과 (0.23ms, 31.2MB)
            테스트 4 〉	통과 (0.26ms, 31.2MB)
            테스트 5 〉	통과 (0.25ms, 31.1MB)
            테스트 6 〉	통과 (0.20ms, 31MB)
            테스트 7 〉	통과 (0.21ms, 31.3MB)
            테스트 8 〉	통과 (0.21ms, 30.9MB)
            테스트 9 〉	통과 (0.21ms, 31MB)
            테스트 10 〉	통과 (0.20ms, 31.2MB)
            테스트 11 〉	통과 (0.23ms, 30.9MB)
            테스트 12 〉	통과 (0.20ms, 31MB)
            테스트 13 〉	통과 (0.21ms, 31.2MB)
            테스트 14 〉	통과 (0.21ms, 31.1MB)
            테스트 15 〉	통과 (0.32ms, 31.3MB)
            테스트 16 〉	통과 (0.29ms, 31.2MB)
     */
}
