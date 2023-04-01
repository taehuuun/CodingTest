using System;

public class Solution 
{
    public int solution(int[,] sizes) 
    {
        // 최대 가로 길이
        int maxWidth = -9999;
        
        // 최대 세로 길이
        int maxHeight = -9999;
        
        // sizes의 GetLength만큼 반복 한다
        for(int i  = 0 ; i < sizes.GetLength(0); i++)
        {
            // 가장 긴 변을 가로로 두기 위한 과정
            // 세로가 가로보다 길다면, 가로 <=> 세로
            if(sizes[i,0] < sizes[i,1])
            {
                int temp = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = temp;
            }
            
            // 가로 길이의 최댓값을 찾는다
            if(maxWidth < sizes[i,0])
            {
                maxWidth = sizes[i,0];
            }
            
            // 세로 길이의 최댓값을 찾는다
            if(maxHeight < sizes[i,1])
            {
                maxHeight = sizes[i,1];
            }
        }
        
        // 최대 가로 길이랑 최대 세로 길이를 곱한다 (최소 직사각형)
        return maxWidth * maxHeight;
    }
}