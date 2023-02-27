using System;

public class Solution 
{
    public int solution(string s) 
    {
        // x에 해당하는 문자 저장 변수
        char x = '\0';
        
        // x와 일치하는 문자 카운트 변수
        int xCnt = 0;
        
        // x와 일치하지 않는 카운트 변수
        int otherCnt = 0;
        
        // 결과
        int answer = 0;
        
        // s 문자열 길이 만큼 반복
        for (int i = 0; i < s.Length; i++)
        {
            // x가 \0일때 s[i]번째 문자를 대입후 xCnt를 증가
            // 아니라면 s[i]번째와 x를 비교하여 일치할때 xCnt증가
            // 일치하지 않으면 otherCnt 증가
            if (x == '\0')
            {
                x = s[i];
                xCnt++;
            }
            else
            {
                
                if (s[i] == x)
                {
                    xCnt++;
                }
                else
                {
                    otherCnt++;
                }
                
                // xCnt와 otherCnt가 일치하면
                // answer를 증가 시키고
                // 각 변수를 초기 상태값으로 대입한다
                if (xCnt == otherCnt)
                {
                    answer++;
                    xCnt = 0;
                    otherCnt = 0;
                    x = '\0';
                }
            }
        }
        
        // 모든 문자를 체크후에 x가 남았다면
        // answer를 증가 시킨다.
        if (x != '\0')
            answer++;
        
        return answer;
    }
}