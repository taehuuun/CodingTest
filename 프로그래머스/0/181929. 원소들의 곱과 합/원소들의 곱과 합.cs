using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        var sumPow = 0;
        var multiple = 1;
        
        foreach(var num in num_list)
        {
            sumPow += num;
            multiple *= num;
        }
        
        sumPow = (int)Math.Pow(sumPow, 2);
        
        return multiple < sumPow ? 1 : 0;
    }
}