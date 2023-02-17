using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        
        // s1의 길이 만큼 반복
        for(int i = 0; i < s1.Length; i++)
        {
            // s2의 길이 만큼 반복
            for(int j = 0; j < s2.Length; j++)
            {
                // s1[i] 와 s2[j]가 일치하면 카운트 증가
                if(s1[i] == s2[j])
                    answer++;
            }
        }
        
        return answer;
    }
}