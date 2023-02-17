using System;

public class Solution {
    public int solution(int n, int t) {
        
        // 처음은 n만큼 세균이 존재
        int answer = n;
        
        // 시간 만큼 반복
        for(int i = 0 ; i < t; i++)
        {
            // 시간마다(t) 2배씩 증가.
            answer *= 2;
        }
        
        return answer;
    }
}