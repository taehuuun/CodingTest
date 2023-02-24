using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        // 문자열의 마지막부터 처음까지 뒤집는다
        for(int i = my_string.Length-1; i>=0; i--)
        {
            answer += my_string[i];
        }
        
        return answer;
    }
}