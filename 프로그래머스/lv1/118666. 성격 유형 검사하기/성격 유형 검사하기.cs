using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string[] survey, int[] choices) 
    {
        string answer = "";
        
        // 선택지에 따라 더하게 될 점수
        int[] scores = { 3, 2, 1, 0, 1, 2, 3 };
        
        // 유형별 점수를 기록 하기 위한 딕셔너리
        Dictionary<char, int> personalityType = new Dictionary<char, int>
        {
            {'R', 0},
            {'T', 0},
            {'C', 0},
            {'F', 0},
            {'J', 0},
            {'M', 0},
            {'A', 0},
            {'N', 0}
        };
        
        // 각 케이스들의 선택을 확인후 해당하는 타입에 점수를 추가 시킨다
        for (int i = 0; i < survey.Length; i++)
        {
            char key = choices[i] < 4 ? survey[i][0] : survey[i][1];
            personalityType[key] += scores[choices[i] - 1];
        }
        
        // CompareScore를 통해 각 유형의 점수를 비교후 result에 유형을 추가한다
        answer += CompareScore('R', 'T', personalityType);
        answer += CompareScore('C', 'F', personalityType);
        answer += CompareScore('J', 'M', personalityType);
        answer += CompareScore('A', 'N', personalityType);
        
        return answer;
    }
    
    // 점수를 비교하여 해당하는 유형을 반환한다
    public char CompareScore(char key1, char key2, Dictionary<char, int> dic)
    {
        return dic[key1] >= dic[key2] ? key1 : key2;
    }
}