using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // 순서쌍은 약수의 개수와 같기 때문에
        // 1 ~ n까지 반복하여 약수를 찾아냄
        for (int i = 1; i <= n; i++)
        {
            // n을 i로 나누어 떨어지면
            // 약수를 찾은것이므로 answer를 증가
            if (n % i == 0)
            {
                answer++;
            }
        }
        
        return answer;
    }
}