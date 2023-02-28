using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int k, int[] score) 
    {
        List<int> hallOfFrameScores = new List<int>();
        List<int> result = new List<int>();

        // score 길이 만큼 반복
        for (int i = 0; i < score.Length; i++)
        {
            // case1. 명예의 전당 리스트 크기가 k 보다 작을땐 우선 다 채움
            if (hallOfFrameScores.Count < k)
            {
                // 1) score 값들을 명예의 전당 리스트에 추가 한다.
                hallOfFrameScores.Add(score[i]);
                
                // 2) 추가된 명예의 전당 리스트를 오름차순으로 정렬 한다.
                hallOfFrameScores.Sort();
        
                // 3) 정렬된 값들중 제일 앞에있는 값(작은값)을 result 리스트에 추가한다.
                result.Add(hallOfFrameScores[0]);
            }
            
            // case2 명예의 전당 리스트 크기가 k 보다 커질 경우
            else
            {
                // 1) score값이랑 명예의 전당의 최소값이랑 비교 (클경우 true)
                if (score[i] > hallOfFrameScores.Min())
                {
                    // 2-true ) 명예의 전당 리스트에 제일 앞에 있는 값(작은 값)을 제거
                    hallOfFrameScores.Remove(hallOfFrameScores[0]);
                    
                    // 2-true ) 해당 score값을 명예의 리스트에 추가
                    hallOfFrameScores.Add(score[i]);
                    
                    // 2-true ) 명예의전당 리스트를 정렬
                    hallOfFrameScores.Sort();
                    
                    // 2-true ) 제일 앞에있는 값을 reuslt 리스트에 추가
                    result.Add(hallOfFrameScores[0]);
                }
                
                else
                {
                    // 2-false) 명예의 전당에서 제일 앞에 있는 값을 result리스트 추가
                    result.Add(hallOfFrameScores[0]);
                }
            }
        }
        
        return result.ToArray();
    }
}