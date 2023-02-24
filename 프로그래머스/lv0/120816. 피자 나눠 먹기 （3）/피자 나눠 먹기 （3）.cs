using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 1;
        
        // Ex) slice = 4, n = 12
        // 1 => 4 * 1 < 4
        // 2 => 4 * 2 < 8
        // 3 => 4 * 3 <= 12
        while(slice * answer < n)
            answer++;
        
        return answer;
    }
}