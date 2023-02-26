using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        // goal문자열 배열과 비교할 결과 리스트 생성
        // 카드 1 인덱스
        int cards1Idx = 0;

        // 카드 2 인덱스
        int cards2Idx = 0;

        // goal 문자열 길이 만큼 반복
        for(int i=0;i<goal.Length;i++)
        {
            // goal의 문자열이 해당 카드1, 카드2의 카드인지 체크후
            // 각 인덱스가 배열의 길이보다 작을때만 인덱스 증가
            if(cards1[cards1Idx].Equals(goal[i]))
            {  
                cards1Idx = (cards1Idx < cards1.Length-1)? cards1Idx + 1 : cards1Idx;    
            }
            else if(cards2[cards2Idx].Equals(goal[i]))
            {   
                cards2Idx = (cards2Idx < cards2.Length-1)? cards2Idx + 1 : cards2Idx;
            }
            else
            {  
                // cards1와 cards2에 둘다 goal의 문자열과 일치 하지 않는다면
                // No를 리턴
                return "No";
            }
        }
        
        // 모든것이 일치한다는 것이므로 Yes 리턴
        return "Yes";
    }
}