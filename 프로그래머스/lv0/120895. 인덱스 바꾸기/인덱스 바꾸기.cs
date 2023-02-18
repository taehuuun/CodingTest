using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        
        string answer = "";
        
        // string -> char[]로 변환
        char[] copyArray = my_string.ToCharArray();
        
        // 간단한 스왑 코드
        char tmp = copyArray[num1];
        copyArray[num1] = copyArray[num2];
        copyArray[num2] = tmp;
        
        // 스왑한 문자들을 연결한다
        answer = string.Concat(copyArray);
        return answer;
    }
}