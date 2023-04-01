using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {  
        int answer = -1;
        
        // numbers의 수들을 모두 더한 값을 저장할 변수
        int sum = 0;
        
        // numbers의 모든 수들을 sum에 더한다
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        
        // 1~9를 모든 더한 값은 45이고 이기 때문에
        // sum의 값은 1~9중 일부 빠진 값들이다
        // 45와 sum을 빼면 빠진 수들의 합을 구할수 있다
        answer = 45 - sum;
        
        return answer;
    }
}