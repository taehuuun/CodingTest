using System;

public class Solution 
{
    public int[] solution(string[] strlist) 
    {
        // 정수형 배열 answer를 생성하여 strlist의 길이만큼 할당
        int[] answer = new int[strlist.Length];
        
        // strlist의 길이만큼 반복하여 문자열의 길이를 계산하여 answer 배열에 저장
        for (int i = 0; i < strlist.Length; i++)
        {
            answer[i] = strlist[i].Length;
        }
        
        // 계산된 문자열 길이가 저장된 answer 배열을 반환
        return answer;
    }
}