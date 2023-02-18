using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        
        // 2진수 -> 10진수 변환
        int binToDigit1 = Convert.ToInt32(bin1,2);
        int binToDigit2 = Convert.ToInt32(bin2,2);

        // 10진수 값 끼리 더한후 2진수로 변환
        answer = Convert.ToString(binToDigit1 + binToDigit2, 2);
        
        return answer;
    }
}