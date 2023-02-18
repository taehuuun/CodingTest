using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        
        // i 부터 j 까지 반복
        for(int copy = i; copy <= j; copy++)
        {
            // curVal에 copy 값 대입
            int curVal = copy;

            // curVal != 0 일때 반복
            while (curVal != 0)
            {
                // curVal를 10으로 나눈 나머지가 k와 같다면
                // answer 증가
                if (curVal % 10 == k)
                {
                    answer++;
                }
                
                // curVal에 10을 나눈 몫을 대입
                curVal /= 10;
            }
        }
        
        return answer;
    }
}