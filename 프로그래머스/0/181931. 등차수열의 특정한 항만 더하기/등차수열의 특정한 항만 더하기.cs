using System;

public class Solution 
{
    public int solution(int a, int d, bool[] included) 
    {
        int answer = 0;
        
        int first = a;
        
        if(included[0])
        {
            answer += first;
        }
        
        for(int i = 1; i < included.Length; i++)
        {
            first += d;
            if(!included[i])
            {
                continue;
            }
            
            answer += first;
        }
        
        return answer;
    }
}