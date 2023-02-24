using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        
        // 10인분 -> 음료수 1개
        int service = n / 10;
        
        // 전체 식 : (12000 * 양꼬치 수) + (음료수 수 * 2000) - (service * 2000)
        // 전체적인 주문 금액 = (12000 * 양꼬치 수) + (음료수 수 * 2000)
        // 서비스 음료수 값 = (service * 2000)
        // 최종 금액 = 전체적인 주문 금액 - 서비스 음료수 값
        answer = 12000 * n + k * 2000 - service * 2000;
        
        return answer;
    }
}