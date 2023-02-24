using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        
        // 4부터 n까지의 모든 수에 대해서 반복
        // 1 2 3 은 약수 3개의 조건이 해당 되지 않음
        for (int i = 4; i <= n; i++) 
        {
            // i의 약수의 개수를 저장하는 변수
            int divisCnt = 0; 
            
            // i의 약수를 구하기 위한 반복문
            for (int j = 1; j <= i; j++) 
            {
                // i가 j로 나누어떨어질 때, j는 i의 약수이다.
                if (i % j == 0) 
                {
                    // 약수의 개수 증가
                    divisCnt++; 

                    // i의 약수가 3개 이상인 경우
                    if (divisCnt == 3) 
                    {
                        // 현재 i의 약수의 개수를 찾았으므로 answer 증가후
                        // 더 이상 반복하지 않고  다음 수로 넘어감
                        answer++;
                        break;            
                    }
                }
            }
        }
        
        return answer;
    }
}