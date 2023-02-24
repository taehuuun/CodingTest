using System;

public class Solution 
{
    public int[] solution(int[] emergency) 
    {
        int[] answer = new int[emergency.Length] ;
        
        // 순서를 정할때 가장 낮은 순위는 배열의 길이이므로
        // 배열의 길이로 초기값 설정
        Array.Fill(answer,emergency.Length);
        
        // emergency길이 만큼 2중 for문을 돌며
        // i 값이 j보다 클경우 (순위가 높다)
        // 현재 answer[i]의 값을 -1 해줌
        for (int i = 0; i < emergency.Length; i++)
        {
            for (int j = 0; j < emergency.Length; j++)
            {
                if (emergency[i] > emergency[j])
                {
                    answer[i]--;
                }
            }
        }

        
        return answer;
    }
}