using System;

public class Solution {
    
    // 발음 할수 있는 단어 리스트.
    string[] checkWord = {"aya", "ye", "woo", "ma"};
    
    public int solution(string[] babbling) {
        // answer 정답 카운트 변수
        int answer = 0;
        
        // CheckBabbling함수 실행 및 리턴값을 answer의 대입
        answer = CheckBabbling(babbling);
        
        // answer 변수 리턴(제출)
        return answer;
    }
    
    // 발음 할수 있는지 체크하는 함수
    public int CheckBabbling(string[] babbling)
    {
        // 기본 count값 0으로 설정
        int count = 0;
        
        // 입력 받은 babbling 배열의 길이 만큼 반복
        for(int i =0 ; i < babbling.Length; i++)
        {
            // checkWord 배열의 길이 만큼 반복
            for(int j = 0; j < checkWord.Length; j++)
            {
                // i번째 babbling 문자열을 j번째 checkWord가 포함되었다면 "X"로 치환
                // Ex) "wyeoo" => "wxo"
                // Ex) "yemawoo" => "xxx"
                babbling[i]=babbling[i].Replace(checkWord[j],"x");
            }
            
            // 비교를 위해 한번더 치환된 i번째 babbling문자열을 "X" => ""로 치환
            for(int j = 0; j < babbling[i].Length; j++)
            {
                babbling[i]=babbling[i].Replace("x","");
            }
            
            // 최종적인 i번째 babbling값이 ""이라면 count증가
            if(babbling[i] == "")
                count++;
        }
       
        return count;
    }
}