using System;

public class Solution 
{
    public int solution(int n) 
     {
        int answer = 0;
        
        // 1부터 n만큼 반복 (10진수 기준 1씩 세는것과 동일)
        for (int i = 1; i <= n; i++)
        {
            // answer -> 0부터 카운트 함으로 먼저 1증가
            answer++;
            
            // ConvertVillage3Num를 통해 10진수 -> 3x마을 숫자로 변환
            answer = ConvertVillage3Num(answer);
        }
        
        return answer;
    }
    
    int ConvertVillage3Num(int num)
    {
        // num이 3으로 나누어 떨어질때를 체크
        if (num % 3 == 0 )
        {
            // 3으로 나누어떨어지기 때문에 1을 증가
            num++;
            
            // 증가된 값을 다시 3x마을 넘버로 변환
            num = ConvertVillage3Num(num);
        }
        
        // num을 문자열로 나타냈을때 3이 포함되었는지 체크
        else if (num.ToString().Contains("3"))
        {
            // 3을 포함하기 때문에 1을 증가
            num++;
            
            // 증가된 값을 다시 3x마을 넘버로 변환
            num = ConvertVillage3Num(num);
        }

        return num;
    }
}