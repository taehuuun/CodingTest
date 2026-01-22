using System;

public class Solution 
{
    public string solution(string code) 
    {
        bool mode = false;
        string answer = "";
        
        for(int i = 0; i < code.Length; i++)
        {
            if(code[i] == '1')
            {
                mode = !mode;
                continue;
            }
            
            if(mode)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                
                answer += code[i];
            }
            else
            {
                if(i % 2 != 0)
                {
                    continue;
                }
                
                answer += code[i];
            }
        }
        
        return string.IsNullOrEmpty(answer) ? "EMPTY" : answer;
    }
}