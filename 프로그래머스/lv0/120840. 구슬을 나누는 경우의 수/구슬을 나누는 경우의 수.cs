using System;

public class Solution 
{
    public int solution(int balls, int share) 
    {
        // Hint를 참고하여 수식을 코드로 재작성
        int answer = combination(balls,share);

        
        return answer;
    }
    
    int combination(int n, int r) {
        if (r == 0 || n == r) {
            return 1;
        } else {
            return combination(n-1, r-1) + combination(n-1, r);
        }
    }
}