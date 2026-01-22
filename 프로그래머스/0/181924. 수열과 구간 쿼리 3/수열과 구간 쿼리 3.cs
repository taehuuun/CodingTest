using System;

public class Solution 
{
    public int[] solution(int[] arr, int[,] queries) 
    {
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            var temp = arr[queries[i, 0]];
            arr[queries[i, 0]] = arr[queries[i, 1]];
            arr[queries[i, 1]] = temp;
        }
        
        return arr;
    }
}