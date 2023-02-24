using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 1;
    
        while(answer * 7 < n)
        {
            answer++;
        }


        return answer;
    }
}