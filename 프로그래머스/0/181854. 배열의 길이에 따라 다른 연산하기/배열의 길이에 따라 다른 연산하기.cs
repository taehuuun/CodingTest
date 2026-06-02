using System;

public class Solution 
{
    public int[] solution(int[] arr, int n) 
    {
        bool even = arr.Length % 2 == 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(even)
            {
                if(i % 2 != 0)
                {
                    arr[i] += n;
                }
            }
            else
            {
                if(i % 2 == 0)
                {
                    arr[i] += n;
                }
            }
        }
        
        
        return arr;
    }
}