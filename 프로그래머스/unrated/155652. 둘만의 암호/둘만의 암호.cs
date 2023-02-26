using System;

public class Solution 
{
    public string solution(string s, string skip, int index) 
    {
        string answer = "";
        
        // a(97) ~ z(122)
        // s문자열의 길이 만큼 반복
        for (int i = 0; i < s.Length; i++)
        {
            // i번째 해당하는 문자(정수)값을 저장
            int charToInt = s[i];
            
            // 1부터 index까지 반복
            for (int j = 1; j <= index; j++)
            {
                // 먼저 저장한 값을 증가
                charToInt++;
                
                // skip문자열에 증가된 문자가 포함하고, 'z'값보다 클 경우 반복
                while (skip.Contains((char)charToInt) || charToInt > 'z')
                {
                    // skip문자열에 포함되면 값을 증가
                    if (skip.Contains((char)charToInt))
                    {
                        charToInt++;
                    }
                    else
                    {
                        // z값보다 큰 경우이므로 a 값을 대입
                        charToInt = 'a';
                    }
                }
            }
            
            // 최종적인 값을 문자형으로 명시하여 answer에 추가
            answer += (char)charToInt;
        }
        
        return answer;
    }
}