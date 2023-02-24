using System;

public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;
        int prevNum = 0;

        // 문자열 s를 공백 기준으로 분리하여 각각의 문자열을 str 변수에 대입하며 반복
        foreach (string str in s.Split(' '))
        {
            // 문자열이 "Z"가 아닌 경우
            if (str != "Z")
            {
                // 문자열을 정수형으로 변환하여 prevNum 변수에 대입하고 answer에 더함
                prevNum = int.Parse(str);
                answer += prevNum;
            }
            // 문자열이 "Z"인 경우
            else
            {
                // 이전에 저장한 prevNum 변수 값을 answer에서 빼줌
                answer -= prevNum;
            }
        }

        return answer;
    }
}