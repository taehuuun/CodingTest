using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        // numbers의 원소들은 모두 양수임으로
        // 배열을 오름차순으로 정렬시 가장 큰값이 맨 오른쪽으로 감
        Array.Sort(numbers);
        
        // 배열이 이미 정렬되어 있기 때문에 맨끝과 그 다음번 값을 곱하면 됨
        answer = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
        
        return answer;
    }
}