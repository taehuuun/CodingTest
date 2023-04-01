using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int left, int right) 
    {
        int answer = 0;
        
        // left부터 right까지 반복
        for(int i = left; i <= right; i++)
        {
            // IsDivisorCountEven함수를 통해 true면 더하고, false면 뺀다
            answer += IsDivisorCountEven(i) ? i : -i;
        }
        
        return answer;
    }
    
    // 약수의 개수가 짝수인지 체크하는 함수
    public bool IsDivisorCountEven(int num)
    {
        // 약수들을 담는 리스트
        List<int> divisor = new List<int>();
        
        // 1 ~ num 반복하면수 약수를 구한다.
        for(int i = 1; i<=num; i++)
        {
            // num이 i로 나누어 떨어지면 약수이기 때문에
            // divisor 리스트에 추가한다.
            if(num % i == 0)
            {
                divisor.Add(i);
            }
        }
        
        // divisor 리스트의 개수가 2로 나누어떨어지면 짝수이다
        return divisor.Count % 2 == 0;
    }
}