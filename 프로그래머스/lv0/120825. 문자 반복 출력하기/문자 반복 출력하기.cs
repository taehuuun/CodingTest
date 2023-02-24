using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        
        // 문자열의 길이 만큼 반복
        for (int i = 0; i < my_string.Length; i++)
        {
            // n 만큼 my_string[i]번째 문자를 반복하여
            // answer에 더함
            for (int j = 0; j < n; j++)
            {
                answer += my_string[i];
            }
        }

        return answer;
    }
}