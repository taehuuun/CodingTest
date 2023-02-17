using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[] {};
        
        
        // SplitString함수 리턴값을 받아온다.
        answer = SplitString(my_str, n);
        
        return answer;
    }
    
    public string[] SplitString(string str, int n)
    {
        // 리턴할 배열의 크기를 정한다.
        // str의 길이에서 n을 나누었을때 
        // 나머지 == 0     길이 = str.Length / n;
        // 나머지 != 0     길이 = str.Length / n + 1
        // Ex) str = "abc1Addfggg4556b" (16), n =6
        // -> 16 % 6 = 2.6666... | 0이 아님
        // -> 16 / 6 = 2 + 1
        // -> 3
        int len = (str.Length % n == 0) ? str.Length / n : str.Length / n + 1;
        
        // Substring할때 잘리기 시작하는 인덱스
        int startIdx = 0;
        
        // Substring할때 startIdx에서 얼마만큼 자를지
        int splitLen = 0;
        
        // 결과 값을 리턴할 배열
        string[] retValue = new string[len];
        
        // len의 길이 만큼 반복한다.
        for(int i = 0; i < len; i ++)
        {
            // startIdx의 값을 정한다
            // Ex) n = 6 -> i값 (0,6,12...)
            startIdx = i * n;
            
            // splitLen의 값을 정한다.
            // startIdx에 n만큼 더한 값이 문자열의 길이와 비교하여
            // 작거나 같다면 n, 크다면 n-((startIdx + n) - str.Length)
            // Ex) str = "abc1Addfggg4556b", startIdx (0,6,12..) n = 6
            // -> startIdx = 0 | 0 <= 12 | 6
            // -> startIdx = 6 | 12 <= 12 | 12
            // -> startIdx = 12 | 18 <=12 | 6 - ((12 + 6 ) - 16)
            // -> 4
            splitLen = (startIdx + n <= str.Length) ? n : n - ((startIdx + n) - str.Length) ;
            
            // str을 startIdx부터 splitLen만큼 자른다.
            retValue[i] = str.Substring(startIdx,splitLen);
        }
        
        // 결과를 리턴한다.
        return retValue;
    }
}