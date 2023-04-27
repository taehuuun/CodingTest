using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[,] targets) 
    {
        List<int[]> targetRangeList = ArrayToList(targets);

        int answer = 1;

        // 시작점을 기준으로 내림차순 정렬
        targetRangeList.Sort((a, b) => b[0].CompareTo(a[0]));

        // 첫 번째 요소를 추출하고, 시작점을 초기화
        int S = targetRangeList[0][0];

        // 나머지 요소를 반복하며 시작점과 끝점을 비교
        for (int i = 1; i < targetRangeList.Count; i++)
        {
            int targetS = targetRangeList[i][0];
            int targetE = targetRangeList[i][1];

            // 현재 target의 끝점이 이전 target의 시작점보다 작거나 같은 경우
            if (targetE <= S)
            {
                // answer를 증가시키고 시작점을 업데이트
                answer++;
                S = targetS;
            }
        }

        // 최종 결과인 answer 리턴
        return answer;
    }
    
    List<int[]> ArrayToList(int[,] array)
    {
        List<int[]> list = new List<int[]>();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int[] tmpArray = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                tmpArray[j] = array[i, j];
            }

            list.Add(tmpArray);
        }

        return list;
    } 
}