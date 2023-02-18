using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        
        // before 문자열을 알파벳 순으로 정렬
        before = String.Concat(before.OrderBy(ch => ch));;
        
        // after 문자열을 알파벳 순으로 정렬
        after = String.Concat(after.OrderBy(ch => ch));;
        
        // before와 after를 비교하여 일치하면 1 아니면 0
        answer = (before == after) ? 1 : 0;
        
        return answer;
    }
}