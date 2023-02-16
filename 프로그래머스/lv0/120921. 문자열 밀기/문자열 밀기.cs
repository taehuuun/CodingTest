using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        
        // ShiftString에서 반환된 값을 제출
        answer = ShiftString(A,B);
        
        return answer;
    }
    
    public int ShiftString(string A, string B)
    {
        // A, B 문자열이 일치 할경우 0 리턴.
        if(A == B)
            return 0;
        
        // 문자열의 길이 만큼 반복 수행 
        // Ex) "hello" => 5번 반복
        for(int i = 0; i < A.Length; i++)
        {
            // Ex) "hello"
            // a => A.Substring(A.Legnth-1,1) => "o"
            // b => A.Substring(0,A.Lenth - 1) => "hell"
            // a + b => "ohell"
            A = A.Substring(A.Length - 1, 1) + A.Substring(0, A.Length - 1);
            
            // 연산 결과가 일치 한다면 i+1를 리턴
            if(A == B)
            {
                return i+1;
            }
        }
        
        // 문자열의 길이 만큼 반복 하여도 일치 하지 않는 경우 -1 리턴
        return -1;
    } 
}