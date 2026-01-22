using System;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int len = num_list.Length + 1;
        int[] answer = new int[len];
        
        for(int i = 0 ; i < num_list.Length; i++)
        {
            answer[i] = num_list[i];
        }

        var lastNum = num_list[num_list.Length - 1];
        var compNum = num_list[num_list.Length - 2];
        
        if(lastNum > compNum)
        {
            answer[answer.Length - 1] = lastNum - compNum;
        }
        else
        {
            answer[answer.Length - 1] = lastNum * 2;
        }
        
        return answer;
    }
}