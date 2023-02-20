using System;

public class Solution {
    public int solution(int[,] lines) {
              int answer = 0;
        int max = 0;
        int min = 0;
        int[] lineArr = new int[200];
            
        for(int i = 0; i < 3; i++)
        {
            max = Math.Max(lines[i,0], lines[i,1]);
            min = Math.Min(lines[i,0], lines[i,1]);
            for(int j = min; j < max; j++)
            {
                lineArr[j + 100]++;
            }
        }
        for(int i = 0; i < lineArr.Length; i++)
        {
            if(lineArr[i] > 1)
            {
                answer++;
            }
        }
        return answer;
    }
}