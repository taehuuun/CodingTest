using System;

public class Solution 
{
    public int[,] solution(int[] num_list, int n) 
    {
        // 2차원 배열 new2DNumList를 선언하고, num_list의 길이를 n으로 나눈 값과 n의 크기를 가진다.
        int[,] answer = new int[num_list.Length / n, n];

        // answer의 각 원소에 num_list의 값을 할당한다.
        // i는 answer의 행 인덱스를 나타내고, j는 열 인덱스를 나타낸다.
        //answer의[i,j]에 할당할 값을 num_list에서 가져올 때,
        // i행과 j열의 인덱스를 이용하여 num_list에서의 인덱스를 구하면 된다.
        // 구한 인덱스는 num_list[i*n + j]로 접근할 수 있다.
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
              answer[i, j] = num_list[i * n + j];
            }
        }
        
        return answer;
    }
}