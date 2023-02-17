using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        
        // str1 문자열에 str2가 포함되어있다면 1, 아니라면 2
        answer = (str1.Contains(str2)) ? 1 : 2;
            
        return answer;
    }
}