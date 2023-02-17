using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        // 공백을 기준으로 문자열을 나눈다
        string[] splitStr = my_string.Split(' ');

        // 더해지는 변수에 splitStr 0번째 값을 대입
        answer = int.Parse(splitStr[0]);
        
        // splitStr 길이만큼 반복
        for(int i = 0 ; i < splitStr.Length; i++)
        {
            // 현재 splitStr의 i번째가 +일때 혹은 -일때 체크
            if (splitStr[i] == "+")
            {
                // 현재 더해진 값에 i+1번째 값을 더한다
                answer += int.Parse(splitStr[i + 1]);
            }
            else if(splitStr[i] == "-")
            {
                // 현재 더해진 값에 i+1번째 값을 뺀다
                answer -= int.Parse(splitStr[i + 1]);
            }
        }
        
        return answer;
    }
}