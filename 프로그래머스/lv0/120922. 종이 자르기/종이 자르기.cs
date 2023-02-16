using System;

public class Solution {
    public int solution(int M, int N) {
        int answer = 0;
        
        // M = 1, N = 1 일경우 자르지 않아도 되므로 0
        // 이외에 경우 M * N - 1 번 만큼 가위질을 해야함
        if(M == 1 && N == 1)
        {
            answer = 0;
        }
        else
        {
            answer = M * N - 1;    
        }
        
        return answer;
    }
}