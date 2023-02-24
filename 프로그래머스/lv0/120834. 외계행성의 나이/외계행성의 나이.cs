using System;

public class Solution 
{
    public string solution(int age) 
    {
        string answer = "";
        
        // age를 문자열로 변환
        string ageToStr = age.ToString();
        
        // ageToStr의 길이 만큼 반복
        for (int i = 0; i < ageToStr.Length; i++)
        {
            // char값에 '0'을 빼면 정수형 값이 나온다 Ex) "2" => 2
            // 해당 정수값을 97(a)을 더하여 char형으로 변환후 answer문자열에 더한다
            answer += (char)(ageToStr[i]-'0'+ 97);
        }
        
        return answer;
    }
}