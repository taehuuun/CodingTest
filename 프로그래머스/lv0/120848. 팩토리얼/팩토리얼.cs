using System;

public class Solution 
{
    public int solution(int n) 
    {
        int facVal = 1; // 숫자를 누적해서 곱할 변수
        int answer = 0; // 결과값을 저장할 변수

        // 2부터 10까지 차례대로 숫자를 누적해서 곱함
        // 3,628,800 최대값이고 이때 팩토리얼 넘버는 10인것을 이용
        for (int i = 2; i <= 10; i++)
        {
            facVal *= i;

            // 곱한 결과가 주어진 숫자와 같으면 결과값을 저장하고 
            // 반복문을 종료
            if (facVal == n)
            {
                answer = i;
                break;
            }
            // 곱한 결과가 주어진 숫자보다 크면 이전 숫자를 결과값으로 저장하고 
            // 반복문을 종료
            else if(facVal > n)
            {
                answer = i - 1;
                break;
            }
        }
        
        return answer;
    }
}