using System;

public class Solution 
{
    public int[] solution(int[] numbers, int num1, int num2) 
    {
        // num2 만큼 answer 배열을 할당
        int[] answer = new int[num2-num1+1];
        
        // num1 부터 num2까지 반복
        for(int i = num1; i <= num2; i++)
        {
            // index는 0부터 시작하기 때문에
            // i - num1값을 answer의 인덱스로 사용
            answer[i - num1] = numbers[i];
        }
        
        return answer;
    }
}