using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] array) 
    {
        int answer = 0;
        
        if(array.Length == 1)
        {
            return array[0];
        }
        
        List<int> modeVal = new List<int>();
        
        // 배열의 각 요소들의 발생 빈도를 저장할 counts 배열을 선언
        int[] counts = new int[1000];
        
        // foreach 루프를 사용하여 array 배열의 각 요소를 순회하며,
        // 해당 요소가 counts 배열에서의 인덱스 역할을 하는 counts[number]를 증가
        foreach (int number in array)
        {
            counts[number]++;
        }
        
        // counts 배열에서 가장 큰 값(가장 많이 나온 요소의 발생 빈도)을 찾아냅니다.
        int maxCount = counts.Max();

        for (int i = 0; i < counts.Length; i++)
        {
            // 최대 빈도수와 일치하는 counts[i] 값을 찾음
            if (counts[i] == maxCount)
            {
                // modeVal에 포함되어있지 않다면 i값을 추가
                if (!modeVal.Contains(i))
                {
                    modeVal.Add(i);
                }
            }
        }
        
        // modeVal 개수가 1보다 큰지 체크
        // 1보다 크다면 최빈값이 여러개 이므로 -1을 출력하고,
        // 최빈값을 리턴한다.
        return (modeVal.Count > 1 )? -1 : modeVal[0];
    }
}