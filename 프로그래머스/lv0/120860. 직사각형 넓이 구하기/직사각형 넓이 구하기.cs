using System;

public class Solution 
{
    public int solution(int[,] dots) 
    {
        int answer = 0;
        
        int widthMax = int.MinValue; // x 좌표의 최대값
        int widthMin = int.MaxValue; // x 좌표의 최소값
        int heightMax = int.MinValue; // y 좌표의 최대값
        int heightMin = int.MaxValue; // y 좌표의 최소값

        for (int i = 0; i < dots.GetLength(0); i++)
        {
            // dots[i,0]과 widthMax중 큰값을 비교 대입
            widthMax = Math.Max(widthMax, dots[i, 0]);
            
            // dots[i,0]과 widthMin 작은값을 비교 대입
            widthMin = Math.Min(widthMin, dots[i, 0]);
            
            // dots[i,1]과 heightMax중 큰값을 비교 대입
            heightMax = Math.Max(heightMax, dots[i, 1]);
            
            // dots[i,1]과 heightMin 작은값을 비교 대입
            heightMin = Math.Min(heightMin, dots[i, 1]);
        }
        
        // 최대값과 최소값을 사용해 직사각형 넓이 계산
        answer = (widthMax - widthMin) * (heightMax - heightMin);
        
        return answer;
    }
}