using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        
        // chicken이 10이상일때 까지 반복
        while(chicken >= 10)
        {
            // answer에 chicken을 10으로 나눈 몫을 더함
            answer += chicken / 10;
            
            // chicken에 chicken을 10으로 나눈 몫과 나머지를 더함
            chicken = chicken / 10 + chicken % 10;
        }     
        
        return answer;

    }
}