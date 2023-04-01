using System;

public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;
        
        // 숫자를 문자형태로 저장된 문자열
        string[] engNum = {"zero","one","two","three","four","five","six","seven","eight","nine"};
        
        // engNum을 돌면서 일치하는 문자를 i값으로 치환 시킨다
        for(int i = 0 ; i < engNum.Length; i++)
        {
            s = s.Replace(engNum[i],i.ToString());
        }
        
        // 문자열을 정수형으로 변환
        answer = int.Parse(s);
        
        return answer;
    }
}