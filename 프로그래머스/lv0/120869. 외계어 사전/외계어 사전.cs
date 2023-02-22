using System;
using System.Linq;

public class Solution 
{
    public int solution(string[] spell, string[] dic) 
    {
        // 초기 answer의 값을 2로 대입
        int answer = 2;

        // 기존 spell 배열을 하나의 문자열로 만들기 위한 변수
        string newSpell = "";
        
        // 기존 spell의 원소들을 newSpell 문자열에 더함
        for (int i = 0; i < spell.Length; i++)
        {
            newSpell += spell[i];
        }
        
        // newSpell 문자열을 정렬
        newSpell = new String(newSpell.OrderBy(x => x).ToArray());
        
        // dic길이 만큼 반복
        for (int i = 0; i < dic.Length; i++)
        {
            // dic[i] 길이와 newSpell의 길이가 일치하는지 체크
            if (dic[i].Length == newSpell.Length)
            {
                // dic[i] 문자열을 정렬
                dic[i] = new String(dic[i].ToCharArray().OrderBy(x => x).ToArray());
                
                // 정렬된 dic[i] 와 newSpell을 비교 일치
                // 이미 길이가 일치 하기때문에 두 문자열이 같다면
                // 조건에 만족하는것이므로 answer에 1대입
                if (dic[i] == newSpell)
                {
                    answer = 1;
                    
                    // 추가 반복은 의미가 없음으로 break
                    break;
                }
            }
        }

        return answer;
    }
}