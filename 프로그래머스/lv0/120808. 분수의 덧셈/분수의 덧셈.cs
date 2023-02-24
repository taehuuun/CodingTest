using System;

public class Solution 
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        int[] answer = new int[2];
        
        // 공통 분모를 만든다
        int commonDenom = denom1 * denom2;
        
        // 각 분자에 분모를 서로 곱하여 더한다
        int addNumer = numer1 * denom2 + numer2 * denom1;
        
        // 기약 분수를 만들기 위한 최대공약수를 구한다.
        int gcd = GCD(addNumer, commonDenom);

        // 결과를 배열로 리턴한다
        return new int[] { addNumer / gcd, commonDenom / gcd };

    }
    
    public int GCD(int a, int b)
    {
        // b가 0일때 a를 리턴
        if (b == 0)
        {
            return a;
        }

        // b가 0아 아닐경우
        // a의 값에 b를 대입, b값에 a와b를 나눈 나머지를 대입후
        // GCD함수를 호출 (재귀)
        return GCD(b, a % b);
    }
}