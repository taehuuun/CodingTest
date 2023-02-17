using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        
        // 데이터를 추가하기 용이한 List 생성
        List<int> result = new List<int>();
        
        // 1부터 n까지 반복
        for(int i = 1; i <= n; i++)
        {
            // n 이 i로 나누어 떨어지면 해당 i값을 리스트에 추가
            if(n % i == 0)
            {
                result.Add(i);
            }
        }
        
        // 결과 제출을 위해 List를 배열로 변환
        answer = result.ToArray();
        
        return answer;
    }
}