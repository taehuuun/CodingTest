using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string strA = a.ToString() + b.ToString();
        string strB = b.ToString() + a.ToString();

        int combA = int.Parse(strA);
        int combB = int.Parse(strB);
        
        answer = Math.Max(combA, combB);
        
        return answer;
    }
}