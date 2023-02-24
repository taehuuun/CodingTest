using System;

public class Solution 
{
    public int solution(int hp) 
    {
        int answer = 0;
        
         // 5로 나눈 몫은 5 장군개미 수이므로 더해준다
        answer += hp / 5;
        
        // 5로 나눈 나머지는 병정, 일개미를 계산하기위해 저장해둔다
        hp %= 5; 

        // 3으로 나눈 나머지가 0이면 3 병정개미의 수아므로 더해준다
        // 아니라면, 3으로 나눈 몫은 병정개미수 3으로 나눈 나머지는 일개미 수이므로 더해준다
        answer += (hp % 3 == 0) ? hp / 3 : (hp / 3 + hp % 3);
        
        return answer;
    }
}