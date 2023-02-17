using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[] {};
        
        List<int> findNums = new List<int>();
        
        // numlist 길이 만큼 반복
        for(int i = 0; i < numlist.Length; i++)
        {
            // numlist[i] 가 n으로 나누어 떨어지면 (n의 배수이면)
            // findNums에 numlist[i]를 Add
            if(numlist[i] % n == 0)
            {
                findNums.Add(numlist[i]);
            }
        }
        
        // findNums는 리스트임으로, 배열로 변환
        answer = findNums.ToArray();
        
        return answer;
    }
}