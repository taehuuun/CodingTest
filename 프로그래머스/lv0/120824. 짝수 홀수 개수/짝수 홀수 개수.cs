using System;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int[] answer = new int[2];
        
        // 짝수 개수를 담는 변수
        int evenCnt = 0;
        
        // 홀수 개수를 담는 변수
        int oddCnt = 0;
        
        // num_list길이 만큼 반복
        for(int i = 0; i < num_list.Length; i++)
        {
            // 짝수인지 홀수인지 체크
            if(num_list[i] % 2 == 0)
            {
                evenCnt++;
            }
            else
            {
                oddCnt++;
            }
        }
        
        answer[0] = evenCnt;
        answer[1] = oddCnt;
        
        return answer;
    }
}