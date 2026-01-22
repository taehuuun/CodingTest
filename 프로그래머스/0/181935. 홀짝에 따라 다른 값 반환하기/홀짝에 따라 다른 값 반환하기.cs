using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        
        // n이 홀수라면 n 이하 모든 홀수의 합
        // n이 짝수라면 n 이하 모든 짝수의 제곱 합
        
        if(n % 2 == 0)
        {
            for(int i = 2; i <= n; i+=2)
            {
                answer += (int)Math.Pow(i, 2);
            }
        }
        else
        {
            for(int i = 1; i <= n; i+=2)
            {
                answer += i;
            }
        }
        
        return answer;
    }
}