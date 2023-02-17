using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        
        // 쉬운 풀이를 위해 num를 문자열로 변환
        string numToStr = num.ToString();
        
        // numToStr의 k가 포함되어 있는지 체크
        if(numToStr.Contains(k.ToString()))
        {
            // numToStr내에서 k의 인덱스를 구함 (0부터 시작하기 때문에 1를 더함)
            answer = numToStr.IndexOf(k.ToString()) + 1;
        }
        else
        {
            // numToStr에 k가 포함되어 있지 않음으로 -1 대입
            answer = -1;
        }
        
        return answer;
    }
}