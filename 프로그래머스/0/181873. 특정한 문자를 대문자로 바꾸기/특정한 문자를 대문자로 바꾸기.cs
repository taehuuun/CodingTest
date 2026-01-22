using System;

public class Solution 
{
    public string solution(string my_string, string alp) 
    {
        string answer = "";
        
        for(int i = 0; i < my_string.Length; i++)
        {
            var current = my_string[i];
            answer += current == alp[0] ? char.ToUpper(current) : current;
        }
        
        return answer;
    }
}