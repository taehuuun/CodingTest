using System;

public class Solution 
{
    public string solution(int[] numLog) 
    {
        string answer = "";
        
        for (int i = 0; i < numLog.Length - 1; i++)
        {
            var diff = numLog[i + 1] - numLog[i];
            switch (diff)
            {
                case 1:
                    answer += 'w';
                    break;
                case -1:
                    answer += 's';
                    break;
                case 10:
                    answer += 'd';
                    break;
                case -10:
                    answer += 'a';
                    break;
            }
        }
        
        return answer;
    }
}