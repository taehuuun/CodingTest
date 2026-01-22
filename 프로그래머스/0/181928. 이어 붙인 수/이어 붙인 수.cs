using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        
        var oddStr = "";
        var evenStr = "";

        foreach (var num in num_list)
        {
            if (num % 2 == 0)
            {
                evenStr += num;
            }
            else
            {
                oddStr += num;
            }
        }
        
        answer = int.Parse(evenStr) + int.Parse(oddStr);
        
        return answer;
    }
}