using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[] {};
        
        answer = GetConsecutiveNumbers(num, total);
        
        return answer;
    }
    
    public int[] GetConsecutiveNumbers(int num, int total)
    {
        // 초기 값은 0
        int startNum = 0;
        
        // 초기 값은 -1 (0 <= total <= 1000)
        int sum = -1;
        
        // sum과 total값이 같지 않으면 반복
        while(sum != total)
        {
            // 합 연산을 위해 sum에 0 대입
            sum = 0;
            
            // startNum부터 startNum + num까지 반복
            for(int i = startNum; i < startNum + num; i++)
            {
                // sum변수에 증가된 i값을 모두 더함
                // Ex) num = 4, total =14
                // 1. 0+1+2+3 = 6  < 14
                // 2. 1+2+3+4 = 10 < 14
                // 3. 2+3+4+5 = 14 == 14
                sum += i;
            }
            
            // 문제에서 주어진 조건이 맞는지 체크
            // sum이 total과 같으면 break;
            // sum이 total보다 작으면 startNum를 1증가
            // sum이 total보다 크면 startNum를 1감소
            // Ex) num = 4, total =14
            // 1. 0+1+2+3 = 6  < 14  (startNum 증가)
            // 2. 1+2+3+4 = 10 < 14  (startNum 증가)
            // 3. 2+3+4+5 = 14 == 14 (break)
            if(sum == total)
            {
                break;
            }
            else if(sum < total)
            {
                startNum++;
            }
            else
            {
                startNum--;                
            }
        }
        
        // 찾은 값을 저장할 배열 선언
        int[] findVal = new int[num];
        
        // num만큼 반복하며 startNum + i한 값을 배열에 대입
        // Ex) num = 4, totla = 14 일때
        // startNum = 2
        // 2+0, 2+1, 2+2, 2+3  => 2,3,4,5 (결과값)
        for(int i = 0 ; i < num; i++)
        {
            findVal[i] = startNum + i;
        }
        
        // 결과값 반환
        return findVal;
    }
}