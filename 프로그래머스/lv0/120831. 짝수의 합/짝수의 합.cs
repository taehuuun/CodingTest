using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        
        // 1부터 n까지 반복
        for(int i = 1; i <= n; i++)
        {
            // i가 2로 나누어 떨어지면 짝수
            if(i % 2 == 0)
            {
                // 짝수 i를 더한다
                answer += i;
            }
        }
        
        return answer;
    }
}