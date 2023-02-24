using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2];
        
        int americano = money / 5500;
        int change = money - 5500 * americano;
        
        answer[0] = americano;
        answer[1] = change;
        
        return answer;
    }
}