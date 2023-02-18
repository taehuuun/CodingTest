using System;
using System.Linq;
using System.Collections.Generic;


public class Solution {
    public string solution(string s) {
        string answer = "";
        
        // 문자열의 각 문자와 나타난 횟수를 담기 용이한 Dictionary 사용
        Dictionary<char,int> checkDic = new Dictionary<char,int>();
        
        // 문자열의 길이 만큼 반복
        for(int i = 0; i < s.Length; i++)
        {
            // 딕셔너리에 s[i]번째 문자가 이미 추가되었는지 체크
            // 추가되어있다면 s[i]를 키로 접근하여 카운트 증가
            // 아니라면 checkDic에 Key: s[i] Value : 1로 추가
            if(checkDic.ContainsKey(s[i]))
            {
                checkDic[s[i]]++;
            }
            else
            {
                checkDic.Add(s[i],1);
            }
        }
        
        // 추가된 키 값들로 딕셔너리에 접근하여
        // Value가 1인 Key만 따로 answer에 추가
        foreach(char Key in checkDic.Keys) 
        {
            if(checkDic[Key] == 1)
            {
                answer += Key;
            }
        }
        
        // answer를 정렬
        answer = String.Concat(answer.OrderBy(ch => ch));
      
        return answer;
    }
}