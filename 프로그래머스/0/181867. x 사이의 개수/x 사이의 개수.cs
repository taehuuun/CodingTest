using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string myString) 
    {
        List<int> answer = new List<int>();
        
        string[] split = myString.Split('x');
        
        for(int i = 0; i < split.Length; i ++)
        {
            if(split[i].Length == 0)
            {
                answer.Add(0);   
            }
            else
            {
                answer.Add(split[i].Length);
            }
        }
        
        return answer.ToArray();
    }
}