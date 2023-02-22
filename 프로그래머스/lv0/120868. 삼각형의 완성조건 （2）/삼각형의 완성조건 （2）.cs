using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] sides) 
    {
        int answer = 0;

        int max = sides.Max();
        int min = sides.Min();

        // 삼각형의 조건  [가장 긴변 < 다른 두변의 합]

        // case1. 가장 긴변이 M인경우 다른 값을 m로두고, 조건에 만족하려면
        // X + m > M | x <= M (x 가 M보다 크면 가장 긴변이 X가 되기 때문에) 
        // => x > M - m , x <= M
        // => M - m < x <= M
        // 즉 M 에서 M-m을 하면 X를 구할수 있다.

        // case2. 나머지 한변이 가장 긴변인 경우
        // M + m > X | X > M (배열의 최대값보다 X가 더 커야 가장 긴변이 됨)
        // M < X < M + m
        // 즉 M + m 에서 m 을 빼면 X를 구할수 있다.

        int case1 = max - (max - min);
        int case2 = (max + min) - (max + 1);
        
        answer = case1 + case2;
        
        return answer;
    }
}