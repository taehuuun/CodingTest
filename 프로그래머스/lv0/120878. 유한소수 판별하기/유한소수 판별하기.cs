using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        // 소인수들을 담을 List 생성
        List<int> primeNums = new List<int>();
        
        if(a % b == 0)
        {
            answer = 1;
        }
        else
        {
             // a, b의 최대 공약수를 구함
            int gcd = GCD(a,b);

            // b(분모)를 최대 공약수로 나눔(기약분수의 분모로 만듦)
            b = b / gcd;

            // 기약분수 형태의 분모값에서 소인수를 구함
            primeNums = GetPrimeNum(b);

            // primeNums의 개수만큼 반복
            for(int i = 0 ; i < primeNums.Count; i++)
            {
                // primeNums[i]의 값이 2 또는 5인지 체크
                // 맞을경우 answer를 1로 대입
                // 아닐경우 answer를 2로 대입


                if(primeNums[i] == 2 || primeNums[i] == 5)
                {
                    answer = 1;
                }
                else
                {
                    answer =2;
                    break;
                }
            }
        }
           
        return answer;
    }
    
    // a와 b의 최대 공약수를 리턴하는 함수
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

    // 주어진 num에서 소인수들을 찾는 함수
    public List<int> GetPrimeNum(int num)
    {
        // 소인수들을 담을 List 생성
        List<int> primNums = new List<int>();
        
        // 나눌 factor의 초기값을 2로 대입
        int factor = 2;
        
        // num이 1보다 크면 반복
        while (num > 1) 
        {
            // num이 factor로 나누어 떨어질때
            if (num % factor == 0) 
            {
                // factor를 리스트에 추가
                primNums.Add(factor);
                
                // num에 factor로 나눈 몫을 대입
                num /= factor;
            }
            
            // 나누어 떨어지지 않을때 factor 증가
            else 
            {
                factor++;
            }
        }

        return primNums;
    }
}