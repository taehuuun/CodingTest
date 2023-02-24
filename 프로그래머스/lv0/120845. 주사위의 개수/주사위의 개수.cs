using System;

public class Solution {
    public int solution(int[] box, int n) {
        
        // 각각의 박스의 길이를 n으로 나누면 한 변에 
        // 들어갈 수 있는 정사각형의 개수가 계산됨
        int answer = (box[0] / n) *(box[1] / n)*(box[2] / n);
        return answer;
    }
}