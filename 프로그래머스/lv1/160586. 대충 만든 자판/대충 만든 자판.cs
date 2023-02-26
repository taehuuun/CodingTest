using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];
        
        // 키로 char형을 값으로 List<int>형을 가지는 keymapDict를 생성한다.
        Dictionary<char, List<int>> keymapDict = new Dictionary<char, List<int>>();
        
        // keymap의 길이 만큼 반복
        for (int i = 0; i < keymap.Length; i++)
        {
            // keymap[i]번째 문자열의 길이 만큼 반복
            for (int j = 0; j < keymap[i].Length; j++)
            {
                // keymap[i][j]에 해당하는 문자를 변수에 저장
                char c = keymap[i][j];
                
                // 해당 문자가 딕셔너리 키에 포함되어있는지 체크
                // 안되어 있다면 c키에 새로운 리스트를 생성
                if (!keymapDict.ContainsKey(c))
                {
                    keymapDict[c] = new List<int>();
                }
                
                // 딕셔너리에 c키에 값으로 j+1값을 리스트에 추가
                keymapDict[c].Add(j + 1);
            }
        }
        
        // targets 길이 만큼 반복
        for (int i = 0; i < targets.Length; i++)
        {
            int cnt = 0;
            
            // targets[i] 문자열 만큼 반복
            for (int j = 0; j < targets[i].Length; j++)
            {
                // targets[i][j]번째 문자를 변수에 저장
                char c = targets[i][j];
                
                // 해당 문자가 딕셔너리에 포함되지 않다면 cnt에 -1대입후 반복문 탈출
                if (!keymapDict.ContainsKey(c))
                {
                    cnt = -1;
                    break;
                }
                
                // 딕셔너리 c키에 해당하는 리스트의 최소값을 cnt에 더한다.
                cnt += keymapDict[c].Min();
            }
            
            // answer에 결과를 추가
            answer[i] = cnt;
        }

        return answer;
    }
}