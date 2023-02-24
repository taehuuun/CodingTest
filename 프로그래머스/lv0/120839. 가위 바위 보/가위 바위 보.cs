using System;

public class Solution 
{
    public string solution(string rsp) 
    {
        // 반환할 문자열을 저장할 변수 초기화
        string answer = ""; 

        // 문자열의 길이만큼 반복
        for (int i = 0; i < rsp.Length; i++) 
        {
            // 만약 현재 문자가 '2' => answer에 '0'추가
            // 만약 현재 문자가 '0' => answer에 '5'추가
            // 만약 현재 문자가 '5' => answer에 '2'추가
            if (rsp[i] == '2') 
            {
                answer += "0";
            }
            else if (rsp[i] == '0')
            {
                answer += "5";
            }
            else
            {
                answer += "2";
            }
        }
        
        // 변환된 문자열 반환
        return answer; 
    }

}