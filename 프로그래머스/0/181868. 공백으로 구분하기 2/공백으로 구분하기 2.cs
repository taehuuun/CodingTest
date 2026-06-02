using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string my_string) 
    {
        List<string> answer = new List<string>();
        
        string tmp = "";
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(my_string[i] != ' ')
            {
                tmp += my_string[i];
            }
            else
            {
                for(int j = i; j< my_string.Length; j++)
                {
                    if(my_string[j] != ' ')
                    {
                        i = j-1;
                        break;
                    }
                }
                
                tmp += ".";
            }
        }
        
        string[] split = tmp.Split('.');
        
        for(int i = 0 ; i < split.Length; i++)
        {
            if(split[i].Length != 0)
            {
                answer.Add(split[i]);
            }
        }
        
        return answer.ToArray();
    }
}