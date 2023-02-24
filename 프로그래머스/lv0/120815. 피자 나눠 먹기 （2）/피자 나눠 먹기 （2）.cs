using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 1;
        
        
        // 피자수는 6조각
        // 반복문을 돌며 answer(판수)를 증가 시키고
        // 6 * answer 값이 n이랑 나누어 떨어질때까지 반복
        while((6 * answer) % n != 0)
        {
            answer++;
        }
            
        
        return answer;
    }
}