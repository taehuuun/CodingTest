using System;

public class Solution 
{
    public string solution(string n_str) 
    {
        if(n_str[0] != '0')
        {
            return n_str;
        }
        
        int start = 0;
        for(int i = 0 ; i < n_str.Length; i++)
        {
            if(n_str[i] != '0')
            {
                break;
            }
            
            start++;
        }
        
        return n_str.Substring(start, n_str.Length - start);
    }
}