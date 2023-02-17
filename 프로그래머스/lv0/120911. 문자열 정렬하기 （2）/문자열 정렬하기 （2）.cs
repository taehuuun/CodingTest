using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        // 입력 받은 문자열을 모두 소문자로 변환
        my_string = my_string.ToLower();
        
        // 입력 받은 문자열을 charArray변환후 정렬 진행
        answer = new String(my_string.ToCharArray().OrderBy (x => x).ToArray());
        
        return answer;
    }
}