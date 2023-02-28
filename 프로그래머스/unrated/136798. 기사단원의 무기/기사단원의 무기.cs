using System;

public class Solution 
{
    public int solution(int number, int limit, int power) 
    {
        int answer = 0;
        
        for (int i = 1; i <= number; i++)
        {
            // 각 i값의 약수 개수를 구한다.
            int divisorCnt = GetDivisorCount(i);

            // 넘지 않다면 그냥 더하고, 넘는다면 power값을 더한다.
            answer += (divisorCnt <= limit) ? divisorCnt : power;
        }

        
        return answer;
    }
    
    int GetDivisorCount(int number)
    {
        int count = 0;
        for (int i = 1; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;

                if (i * i < number)
                {
                    count++;
                }
            }
        }

        return count;
    }
}