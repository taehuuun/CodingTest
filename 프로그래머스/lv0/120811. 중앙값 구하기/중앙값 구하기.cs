using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        // 오름차순으로 배열을 정렬
        Array.Sort(array);
        
        // 배열의 가운데 값을 리턴
        return array[(array.Length-1)/2];
    }
}