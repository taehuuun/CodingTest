using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        
        // array의 max값을 찾음
        int max = array.Max();
        
        // Array.Indexof를 통해 array내 max값의 인덱스를 구함
        int idx = Array.IndexOf(array, max);
        
        // 얻은 결과들을 answer에 대입
        answer[0] = max;
        answer[1] = idx;
        
        return answer;
    }
}
