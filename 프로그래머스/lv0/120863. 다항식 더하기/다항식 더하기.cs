using System;

public class Solution 
{
    public string solution(string polynomial) 
    {
        string answer = "";
        
        // 해당 문제는 +연산만 진행함으로 공백 제거후 +를 기준으로 문자열을 나눈다
        string[] splitStr = polynomial.Replace(" ","").Split('+');
        
        // x의 계수 연산 결과를 저장할 변수
        int xCount = 0;
        
        // 상수의 연산 결과를 저장할 변수
        int nCount = 0;
        
        // splitStr의 길이 만큼 반복        
        for (int i = 0; i < splitStr.Length; i++)
        {
            // i번째 문자열이 x를 포함할때
            if (splitStr[i].Contains("x"))
            {
                // 길이가 1이라면 xCount를 1증가
                // 아니라면 "3x" 같은 형태이기에 
                // 문자열을 0부터 splitStr[i]길이 -1 만큼 자름
                // 결과를 정수형으로 변환 하여 xCount에 더함
                if (splitStr[i].Length == 1)
                {
                    xCount++;
                }
                else
                {
                    string temp = splitStr[i].Substring(0, splitStr[i].Length - 1);
                    xCount += int.Parse(temp);
                }
            }
            else
            {
                // i번째 문자열이 x를 포함하지 않을때
                // 정수값이므로 splitStr[i] 문자열을 정수로 변환뒤
                // nCount 변수에 더함
                nCount += int.Parse(splitStr[i]);
            }
        }
        
        // 출력할때 3가지 케이스를 고려하여 출력해야함
        // case1. x항 계수 값과 상수항이 0이 아닐때        => "4x + 2"
        // case2. x항 계수 값이 0이고 상수항이 0이 아닐때   => "2"
        // case3. x항 계수 값이 0이 아니고 상수항이 0일때   => "4x"
        if (xCount != 0 && nCount != 0)
        {
            // x의 계수가 1일땐 생략 해야함
            answer = (xCount > 1) ? $"{xCount}x + {nCount}" : $"x + {nCount}";
        }
        else if (xCount == 0 && nCount != 0)
        {
            answer = $"{nCount}";
        }
        else
        {
            // x의 계수가 1일땐 생략 해야함
            answer = (xCount > 1 ) ? $"{xCount}x" : "x";
        }
        
        return answer;
    }
}