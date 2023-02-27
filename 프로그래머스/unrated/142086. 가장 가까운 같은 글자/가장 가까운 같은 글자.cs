using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string s) 
    {
        // 기준 문자로 부터 비교할 문자열
        string compStr = "";
        
        // 결과를 저장할 리스트
        List<int> result = new List<int>();
        
        // s의 길이 만큼 반복
        for (int i = 0; i < s.Length; i++)
        {
            // compStr이 비어있거나, s[i]문자가 포함되지 않았을 경우
            if (compStr == "" || !compStr.Contains(s[i]))
            {
                // 앞에 아무것도 없는 경우 이므로, result에 -1 추가
                result.Add(-1);
            }
            else
            {
                // compStr에 s[i]문자가 포함되어 있는 경우
                // s[i]와 일치하는 문자가 compStr에 몇번째 있는지 카운트 하는 변수
                int count = 0;
                
                // compStr문자열의 맨뒤부터 0번째 까지 반복
                for (int j = compStr.Length-1; j >= 0; j--)
                {
                    // 카운트를 증가 시킨다.
                    count++;
                    
                    // 일치하는 문자를 찾았을 경우
                    if (compStr[j] == s[i])
                    {
                        // 증가된 카운트를 result에 추가하고 for문을 종료한다
                        result.Add(count);
                        break;
                    }
                }
            }
            
            // compStr에 s[i]번째 문자열을 추가한다
            compStr += s[i];
        }
        
        // 결과 리스트를 배열로 변환후 리턴
        return result.ToArray();
    }
}