using System;

public class Solution 
{
    public int solution(int[] arr1, int[] arr2) 
    {
        int answer = 0;
        
        if(arr1.Length != arr2.Length)
        {
            return arr1.Length > arr2.Length ? 1 : -1;
        }
        
        int arr1Sum = 0;
        int arr2Sum = 0;
        
        for(int i = 0 ; i < arr1.Length; i++)
        {
            arr1Sum += arr1[i];
        }
        
        for(int i = 0; i < arr2.Length; i++)
        {
            arr2Sum += arr2[i];
        }
        
        if(arr1Sum == arr2Sum)
        {
            return 0;
        }
        
        return arr1Sum > arr2Sum ? 1 : -1;
    }
}