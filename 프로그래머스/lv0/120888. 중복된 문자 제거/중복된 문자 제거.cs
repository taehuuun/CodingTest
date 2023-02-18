using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        // my_string 길이 만큼 반복
        for(int i = 0 ; i < my_string.Length; i++)
        {
            // answer에 my_string[i]번째 문자가 포함되었는지 체크
            // 포함되어 있지 않다면 answer에 추가
            if(!answer.Contains(my_string[i]))
            {
                answer += my_string[i];
            }
        }
    
        
        return answer;
    }
}