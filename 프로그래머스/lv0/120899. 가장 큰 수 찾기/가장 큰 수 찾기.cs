using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        
        // max값을 찾기 위해 초기값을 범위에 속하지 않는 작은 값으로 대입
        int max = -99;
        
        // index를 찾기 위해 범위 밖인 -1 값으로 대입
        int idx = -1;
        
        for(int i = 0; i < array.Length; i++)
        {
            // array의 i번째 값이 max값보다 클때
            // max값을 array[i]의 값으로 대입
            // idx값을 i에 대입
            if(array[i] > max)
            {
                max = array[i];
                idx = i;
            }
        }
        
        // 얻은 결과를 answer 배열에 대입
        answer[0] = max;
        answer[1] = idx;
        
        return answer;
    }
}