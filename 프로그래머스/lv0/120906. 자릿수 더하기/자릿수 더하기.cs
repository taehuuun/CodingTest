using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // n이 0아닐때 반복
        while(n != 0)
        {
            // n을 10으로 나눈 나머지를 anwer에 더함
            answer += n % 10;
            
            // n을 10으로 나눈 몫으로 대입
            n /= 10;
        }
        
        return answer;
    }
}