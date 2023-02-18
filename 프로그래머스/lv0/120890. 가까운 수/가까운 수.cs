using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        // 차이를 저장할 변수 작은 값을 찾아야하기에 큰 값을 대입
        int dif = 9999;
        
        // 제일 차이가 적은 array의 값을 저장할 변수
        int key = 0;
        
        // array길이 만큼 반복
        for(int i = 0; i < array.Length; i++)
        {
            // 현재 array 값과 n을 뺀 차이 값을 변수에 저장
            int curDif = Math.Abs(array[i] - n);
            
            // dif와 curDif 차이 비교후 같은지 확인
            // 같다면 array[i]외 key 비교하여 작은 값 저장
            // 더 작다면 dif와 key 변수 값을 교체
            if( curDif < dif)
            {
                dif = curDif;
                key = array[i];
            }
            else if(curDif == dif)
            {
                if(array[i] < key)
                {
                    key = array[i];
                }
            }
        }
        
        // 최종 key를 answer를 대입
        answer = key;
        
        return answer;
    }
}