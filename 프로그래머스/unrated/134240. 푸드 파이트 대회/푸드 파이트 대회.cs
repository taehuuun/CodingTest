using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public string solution(int[] food) 
    {
        // 물이 위치하게 되는 인덱스
        int waterIdx = 0;
        
        // 0인덱스 기준 왼쪽 부분을 추가하게 될 문자열
        string foodStr = "";
        
        // 결과 문자열
        string result = "";
        
        // food의 각 값을 2로 나눈 몫을 저장할 리스트
        List<int> quotients = new List<int>();
        
        // food 길이 만큼 반복
        for (int i = 1; i < food.Length; i++)
        {
            // i번째 값을 2를 나눈 몫을 리스트에 추가
            quotients.Add(food[i] / 2);
            
            // 몫들의 합이 waterIdx의 값이 됨
            waterIdx += food[i] / 2;
        }
        
        // 몫이 저장된 리스트 개수 만큼 반복
        for (int i = 0; i < quotients.Count; i++)
        {
            // i번째 값만큼 문자를 추가
            for (int j = 0; j < quotients[i]; j++)
            {
                foodStr += i+1;
            }
        }
        
        // result 문자열에 foodStr과 0 foodStr의 반전문자열을 더함
        result = $"{foodStr}0{ReverseString(foodStr)}";
    
        return result;
    }
    
    // 문자열을 반전 시키는 함수
    string ReverseString(string str)
    {
        char[] charArr = str.ToCharArray();
        Array.Reverse(charArr);
        return new string(charArr);
    }
}