using System;

public class Solution {
    public long solution(string numbers) {
        
        long answer = 0;
        
        // 각 케이스를 문자열 배열로 생성
        string[] numToStr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        // numToStr의 길이만큼 반복
        for(int i =0 ; i<numToStr.Length; i++)
        {
            // numToStr[i]와 해당하는 문자열이 있으면 i로 치환
            numbers = numbers.Replace(numToStr[i],i.ToString());
        }
        
        // 결과값 (string)을 long 타입으로 변환
        answer = long.Parse(numbers);
        
        return answer;
    }
}