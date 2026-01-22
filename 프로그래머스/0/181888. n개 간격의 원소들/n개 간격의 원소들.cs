using System;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        int resultLen = num_list.Length % n == 0 ? num_list.Length / n :  num_list.Length / n + 1;
        int[] answer = new int[resultLen];
        
        int index = 0;
        for (int i = 0; i < resultLen; i ++)
        {
            index = i * n;
            answer[i] = num_list[index];
        }
        
        return answer;
    }
}