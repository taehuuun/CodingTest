using System;

public class Solution 
{
    public int solution(int[] absolutes, bool[] signs) 
    {
        int answer = 0;
        
        // signs의 각 부호를 체크하여 더하거나 뺀다
        for(int i = 0; i < signs.Length; i++)
        {
            answer += signs[i] ? absolutes[i] : -absolutes[i];
        }
        
        return answer;
    }
}