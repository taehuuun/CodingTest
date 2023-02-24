using System;

public class Solution {
    public int solution(int[] numbers) {
        
        // 최대값을 구하기 위해 말도 범위보다 작은값 대입
        int answer = -99999;
        
        // 길이가 2일때는 반복문 순회 없이 0번째와 1번째 곱한값만 반환
        // Ex) [-10000,10000] 같은 경우도 존재하기 때문
        if(numbers.Length == 2)
        {
            return numbers[0] * numbers[1];
        }
        
        // numbers의 길이 만큼 2중으로 반복
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                // 자기 자신을 곱하는걸 방지 하기 위해 인덱스가 서로 다를때
                if (i != j)
                {
                    // i번째 값 * j번째 값이 answer보다 크면
                    // answer값 교체
                    if (answer < numbers[i] * numbers[j])
                    {
                        answer = numbers[i] * numbers[j];
                    }
                }
            }
        }
        
        return answer;
    }
}