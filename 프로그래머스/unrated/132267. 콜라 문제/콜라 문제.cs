using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        
        // n이 a크거나 같을 때 (a가 3일 때, n이 3보다 크거나 같아야함)
        while (n >= a)
        {
            // 가지고 있는 병의수(n)을, a만큼 묶어서 최대한 교환(n/a), 교환 받을 땐 b개씩 줌 (n/a)에 b를 곱함
            answer += (n / a) * b;
            
            // 교환 받은 병수와 교환 하지 못하고 남은 병수를 더함
            n = (n / a) * b + n % a;
        }
        
        return answer;
    }
}