using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n) 
    {
        List<int> primeFactors = new List<int>();

        // i는 2부터 n까지 증가
        for (int i = 2; i <= n; i++) 
        {
            // n이 i로 나누어 떨어지면 반복
            while (n % i == 0) 
            {
                // 리스트에 i값이 존재 하지 않을때 Ex) 2 2 3 처럼 중복수 방지 
                if (!primeFactors.Contains(i))
                {
                    // 소인수 i를 primeFactors 리스트에 추가
                    primeFactors.Add(i); 
                }

                // n을 i로 나눈 몫으로 갱신
                n /= i; 
            }
        }
        
        return primeFactors.ToArray();
    }
}