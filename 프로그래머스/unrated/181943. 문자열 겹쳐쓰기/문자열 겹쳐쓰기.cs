using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";
        
        for (int i = 0; i < my_string.Length; i++)
        {
            if (i == s)
            {
                for (int j = 0; j < overwrite_string.Length; j++)
                {
                    answer += overwrite_string[j];
                }

                i += overwrite_string.Length-1;
            }
            else
            {
                answer += my_string[i];
            }
        }
        
        return answer;
    }
}