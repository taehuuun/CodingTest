using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        
        // 2부터 n까지 숫자중에서 나머지가 1인 수를 찾는다
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 1)
            {
                answer = i;
                break;
            }
        }
        
        return answer;
    }
}