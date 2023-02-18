using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        // my_string 길이 만큼 반복
        for(int i = 0 ; i < my_string.Length; i++)
        {
            // 각 문자가 소문자인지 체크후 소문자 -> 대문자, 대문자 -> 소문자 변환
            answer += Char.IsLower(my_string[i])?  Char.ToUpper(my_string[i]) : Char.ToLower(my_string[i]);
        }
        
        return answer;
    }
}