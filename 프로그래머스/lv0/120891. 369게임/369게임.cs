using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        
        while (order != 0)
        {
            // order를 10으로 나눈 나머지를 구한다
            int remain = (order % 10);
                
            // 나머지가 3으로 나누어 떨어지면 카운트를 증가한다
            if( remain % 3 == 0 && remain != 0)
                answer++;
            
            // order를 10으로 나눈 몫으로 바꾼다
            order /= 10;
        }
        
        return answer;
    }
}