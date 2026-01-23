using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) 
    {
        int answerLen = queries.GetLength(0);
        int[] answer = new int[answerLen];
        
        for(int i = 0 ; i < answerLen; i++)
        {
            var temp = int.MaxValue;
            for(int j = queries[i,0]; j <= queries[i,1]; j++)
            {
                if(arr[j] > queries[i,2])
                {
                    temp = Math.Min(temp, arr[j]);
                }
            }
            
            if(temp == int.MaxValue)
            {
                temp = -1;
            }        
            
            answer[i] = temp;
        }
        
        
        return answer;
    }
}