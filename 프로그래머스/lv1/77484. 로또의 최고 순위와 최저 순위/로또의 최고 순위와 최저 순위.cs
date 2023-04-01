using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int[] answer = new int[2];
        
        // 맞춘 수에 따른 순위 딕셔너리
        Dictionary<int,int> rank = new Dictionary<int,int>()
        {
            {6,1},
            {5,2},
            {4,3},
            {3,4},
            {2,5},
            {1,6},
            {0,6}
        };
        
        // 맞춘 개수
        int correctCnt = 0;
        
        // 0의 개수
        int zeroCnt = 0;
        
        // lottos의 길이 만큼 반복
        for(int i = 0; i < lottos.Length; i++)
        {
            // 0가 일치하는 경우 zeroCnt 증가
            if(lottos[i] == 0)
            {
                zeroCnt++;
            }
        }
        
        // win_nums 길이 만큼 반복
        for(int i = 0 ; i < win_nums.Length; i++)
        {
            // lottos에 win_nums[i]값이 포함되어 있다면 correctCnt 증가
            if(lottos.ToList().Contains(win_nums[i]))
            {
                correctCnt++;
            }
        }
        
        // 각 케이스 별 순위를 대입
        answer[0] = rank[correctCnt + zeroCnt];
        answer[1] = rank[correctCnt];
        
        return answer;
    }
}