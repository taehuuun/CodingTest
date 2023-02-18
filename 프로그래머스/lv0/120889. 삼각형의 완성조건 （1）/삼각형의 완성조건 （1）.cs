using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        
        // 최대값을 제외한 길이들을 더할 변수
        int sum = 0;
        
        // 최대값의 인덱스를 담는 변수 
        // sides의 Max값을 찾고, IndexOf함수로 해당 값의 인덱스를 가져온다
        int maxIdx = Array.IndexOf(sides,sides.Max());
        
        // sides 길이 만큼 반복
        for(int i = 0 ; i < sides.Length; i++)
        {
            // maxIdx와 같은 인덱스라면 패스
            if(i == maxIdx)
                continue;
            
            // 나머지 인덱스 값들은 모두 더한다
            sum += sides[i];
        }
        
        // 최대값과 인덱스의 합을 비교하여 작다면 1 아니라면 2
        answer = (sides[maxIdx] < sum) ? 1 : 2;
        
        return answer;
    }
}