using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        // array의 길이 만큼 반복
        for(int i = 0; i < array.Length; i++)
        {
            // i번째 array값을 문자열로 변경
            string arrayToStr = array[i].ToString();
            
            // arrayToStr의 길이만큼 반복
            for(int j = 0; j < arrayToStr.Length; j++)
            {
                // arrayToStr의 j번째 char값이 7인지 비교
                if(arrayToStr[j] == '7')
                    answer++;
            }
        }
        
        return answer;
    }
}