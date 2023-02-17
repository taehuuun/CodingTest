using System;

public class Solution {
    public string[] solution(string[] quiz) {
        
        string[] answer = new string[quiz.Length];
        
        for(int i = 0; i < quiz.Length; i++)
        {
            answer[i] = CheckCorrectOperation(quiz[i]) ? "O" : "X";
        }
        
        return answer;
    }
    
    // 올바른 수식인지 판단하는 함수.
    public bool CheckCorrectOperation(string str)
    {
        // 공백을 기준을 str을 자름.
        string[] elements = str.Split(" ");;

        // elements[0] -> 연산자의 왼쪽 값
        int leftVal = int.Parse(elements[0]);
        
        // elements[2] -> 연산자의 오른쪽 값
        int rightVal = int.Parse(elements[2]);
        
        // elements[4] -> str의 결과 값
        int resultVal = int.Parse(elements[4]);
        
        // str의 결과값과 실제 leftVal, rightVal값을 실제 연산하여 비교 진행
        return resultVal == ((elements[1] == "+") ? leftVal + rightVal : leftVal - rightVal);
    }
}