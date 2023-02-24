using System;

public class Solution 
{
    public int solution(int[] numbers, int k) 
    {
        int answer = 0;
        
        // idx에 마지막으로 던진 사람의 인덱스를 구하는 수식을 대입한다.
        // (2 * (k - 1)) % numbers.Length를 계산하여 나머지 값을 idx에 대입한다.
        // 이 때 idx는 numbers의 길이보다 클 수 없으므로 numbers.Length로 나머지 연산을 한다.
        int idx = (2 * (k - 1)) % numbers.Length;
        
        // 위 과정을 통해 마지막으로 던진 사람의 인덱스를 구하고
        // 해당하는 값을 출력한다.
        answer = numbers[idx];
        
        return answer;
    }
}