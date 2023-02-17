using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // CheckSquareNumber의 리턴값이 true면 1, false면 2
        answer = CheckSquareNumber(n) ? 1 : 2;
        
        return answer;
    }
    
    public bool CheckSquareNumber(int n)
    {
        // 1 ~ n까지 반복
        for(int i = 1; i <= n; i++)
        {
            // i를 제곱했을때 n 값이 나오면 true 리턴
            if(Math.Pow(i, 2) == n)
            {
                return true;
            }
        }
        
        // 반복문 종료 = 모든 i값을 제곱해도 n과 일치 하지 않음 = 제곱수가 아님
        return false;
    }
}