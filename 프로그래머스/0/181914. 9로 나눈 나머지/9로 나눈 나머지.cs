using System;

public class Solution 
{
    public int solution(string number) 
    {
        int answer = 0;
        int sum = 0;
        
        for(int i = 0 ; i < number.Length; i++)
        {
            sum += number[i] - '0';
        }
        
        answer = sum % 9;
        
        return answer;
    }
}