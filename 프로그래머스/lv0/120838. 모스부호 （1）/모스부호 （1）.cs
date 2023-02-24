using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string letter) 
    {
        // 모스 부호를 저장할 딕셔너리 생성
        Dictionary<string, char> morseDic = new Dictionary<string, char>(); 
        
        // 알파벳에 대응하는 모스 부호 배열
        string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
            "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." }; 
        
        // 문자열을 공백 기준으로 분리하여 배열로 저장
        string[] splitMorse = letter.Split(" "); 
        
        // 결과 문자열 초기화
        string answer = "";

        // 모스 부호와 알파벳을 딕셔너리에 추가
        for (int i = 0; i < morse.Length; i++)
        {
            morseDic.Add(morse[i], (char)('a' + i));
        }

        // 모스 부호를 알파벳으로 변환하여 결과 문자열에 추가
        for (int i = 0; i < splitMorse.Length; i++)
        {
            answer += morseDic[splitMorse[i]];
        }

        return answer;
    }
}