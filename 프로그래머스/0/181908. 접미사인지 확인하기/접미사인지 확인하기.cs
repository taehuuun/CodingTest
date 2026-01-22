using System;

public class Solution 
{
    public int solution(string my_string, string is_suffix) 
    {
        int answer = 0;
        
        if(my_string.Length < is_suffix.Length)
        {
            answer = 0;
        }
        else
        {
            answer = my_string.Substring(my_string.Length - is_suffix.Length) == is_suffix ? 1 : 0;
        }
        
        return answer;
    }
}